using HttpRS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using ApexCloudApi.ApiMsg;
using ApexCloudApi.ApiMsg.Future;
using Newtonsoft.Json;


namespace ApexCloudApi.Mgr
{
    public class FireOrderManager
    {
        private static FireOrderManager _fireOrderMgrInstance { get; set; }
        public static FireOrderManager GetInstance(string gmrid, CookieCollection cookies, HttpHeaderList headers)
        {
            if (_fireOrderMgrInstance == null)
            {
                _fireOrderMgrInstance = new FireOrderManager(gmrid, cookies, headers);
            }
            return _fireOrderMgrInstance;
        }

        private string _gmrid { get; set; }
        private CookieCollection _loginCookies { get; set; }
        private HttpHeaderList _header { get; set; }
        private OrderCaseManager _orderCaseMgrInstance { get; set; }

        //private string _sendFutureOrderApi = "https://fincloud.apex.com.tw/FinCloud/api/GVE/PutOrder"; //2018
        private string _sendStockOrderApi = "http://www.fincloud.tw/FinCloud/api/GVE/PutOrder";//2019
        private string _sendFutureOrderApi = "http://www.fincloud.tw/FinCloud/api/GVE/PutOrder"; //2019

        private FireOrderManager(string gmrid, CookieCollection cookies, HttpHeaderList headers)
        {
            this._gmrid = gmrid;
            this._loginCookies = cookies;
            this._header = headers;            
        }

        /// <summary>
        /// 送出股票買賣委託單
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="buySell"></param>        
        /// <param name="price"></param>
        /// <param name="vol"></param>
        /// <returns></returns>
        public string AddStockOrder(string symbol,
            StockBuyOrSell buySell,            
            decimal price,
            int vol)
        {
            HttpSender http = new HttpSender(_sendStockOrderApi);
            CookieContainer cookies = new CookieContainer();
            cookies.Add(this._loginCookies);

            string buySellStr = "";
            switch (buySell)
            {
                case StockBuyOrSell.Buy:
                    buySellStr = "B";
                    break;
                case StockBuyOrSell.Sell:
                    buySellStr = "S";
                    break;
                case StockBuyOrSell.MarginBuy:
                    buySellStr = "MB";
                    break;
                case StockBuyOrSell.MarginSell:
                    buySellStr = "MS";
                    break;
                case StockBuyOrSell.RentBuy:
                    buySellStr = "RB";
                    break;
                case StockBuyOrSell.RentSell:
                    buySellStr = "RS";
                    break;
                default:
                    break;
            }

            PutOrderPostReq req = new PutOrderPostReq
            {
                assetcode = symbol,
                bs = buySellStr,
                gmrid = this._gmrid,                
                ot = "LMT",                
                price = price,
                volume = vol,
                fip = "125.227.70.205"
            };

            ResponseResult response = http.SendRequest(HttpRequestMethod.Post, JsonConvert.SerializeObject(req), this._header, cookies);
            Console.Write(response.ResponseBody);
            PutOrderPostRsp rsp = JsonConvert.DeserializeObject<PutOrderPostRsp>(response.ResponseBody);
            PutOrderIdToCase(rsp.msg.Trim());
            return rsp.msg.Trim();
        }

        public string AddFutureOrder(string symbol,
            FutureBuyOrSell buySell, 
            bool isDayTrade,
            FutureTradeCondition condition,
            FuturePriceType priceType, 
            decimal price,
            int vol)
        {
            HttpSender http = new HttpSender(_sendFutureOrderApi);
            CookieContainer cookies = new CookieContainer();
            cookies.Add(this._loginCookies);

            string odrPriceType = "";
            string odrCondition = "";
            if (condition == FutureTradeCondition.IOC)
            {
                odrCondition = "IOC";
                odrPriceType = "MKT";
            }
            else if (condition == FutureTradeCondition.ROD)
            {
                odrCondition = "ROD";
                odrPriceType = "LMT";
            }
            else
            {
                odrCondition = "FOK";
                odrPriceType = "LMT";
            }

            PutOrderPostReq req = new PutOrderPostReq
            {
                assetcode = symbol,
                bs = buySell == FutureBuyOrSell.Buy ? "B" : "S",
                dt = isDayTrade ? 50 : 0,
                gmrid = this._gmrid,
                oct = "O",
                on = odrCondition,
                ot = odrPriceType,
                price = condition == FutureTradeCondition.IOC ? 0 : price,
                volume = vol,
                fip = "125.227.70.205"
            };

            ResponseResult response = http.SendRequest(HttpRequestMethod.Post, JsonConvert.SerializeObject(req), this._header, cookies);
            Console.Write(response.ResponseBody);
            PutOrderPostRsp rsp = JsonConvert.DeserializeObject<PutOrderPostRsp>(response.ResponseBody);
            PutOrderIdToCase(rsp.msg.Trim());
            return rsp.msg.Trim();
        }

        private void PutOrderIdToCase(string orderId)
        {
            _orderCaseMgrInstance = OrderCaseManager.GetInstance(this._gmrid, this._loginCookies, this._header);
            _orderCaseMgrInstance.AddNewOrderId(orderId.Trim());
        }

        public string AddOptionOrder(
            string symbol,
            FutureBuyOrSell buySell, 
            FutureCloseType openClose,            
            FutureTradeCondition condition,
            FuturePriceType priceType, 
            decimal price,
            int vol)
        {
            HttpSender http = new HttpSender(_sendFutureOrderApi);
            CookieContainer cookies = new CookieContainer();
            cookies.Add(this._loginCookies);

            string odrPriceType = "";
            string odrCondition = "";
            if (condition == FutureTradeCondition.IOC)
            {
                odrCondition = "IOC";
                odrPriceType = "MKT";
            }
            else if (condition == FutureTradeCondition.ROD)
            {
                odrCondition = "ROD";
                odrPriceType = "LMT";
            }
            else
            {
                odrCondition = "FOK";
                odrPriceType = "LMT";
            }

            PutOrderPostReq req = new PutOrderPostReq
            {
                assetcode = symbol,
                bs = buySell == FutureBuyOrSell.Buy ? "B" : "S",                
                gmrid = this._gmrid,
                oct = openClose == FutureCloseType.Open ? "O" :"C",
                on = odrCondition,
                ot = odrPriceType,
                price = condition == FutureTradeCondition.IOC ? 0 : price,
                volume = vol,
                fip = "125.227.70.205"
            };

            ResponseResult response = http.SendRequest(HttpRequestMethod.Post, JsonConvert.SerializeObject(req), this._header, cookies);
            Console.Write(response.ResponseBody);
            PutOrderPostRsp rsp = JsonConvert.DeserializeObject<PutOrderPostRsp>(response.ResponseBody);
            PutOrderIdToCase(rsp.msg.Trim());
            return rsp.msg.Trim();
        }
    }

    public enum FutureBuyOrSell
    {
        Buy,
        Sell
    }

    public enum FutureTradeCondition
    {
        IOC,
        ROD,
        FOK        
    }

    public enum FuturePriceType
    {
        Market,
        Limit
    }

    public enum FutureCloseType
    { 
        Open,
        Close        
    }

    public enum StockBuyOrSell
    {
        /// <summary>
        /// 現貨買進
        /// </summary>
        Buy, //B
        /// <summary>
        /// 現貨賣出
        /// </summary>
        Sell, //S
        /// <summary>
        /// 融資買進
        /// </summary>
        MarginBuy, //MB
        /// <summary>
        /// 融券賣出
        /// </summary>
        MarginSell,//MS
        /// <summary>
        /// 沖銷融資買進
        /// </summary>
        RentBuy, //RB
        /// <summary>
        /// 沖銷融券賣出
        /// </summary>
        RentSell, //RS

        None //not set

    }

    
}
