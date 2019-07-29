using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HttpRS;
using ApexFincloud.ApiMsg;
using Newtonsoft.Json;
using System.Net;
using ApexCloudApi;
using ApexCloudApi.Mgr;

namespace ApexFincloud
{
    public partial class Form1 : Form
    {
        private ApiFacade _apexApiFacade { get; set; }       

        public Form1()
        {
            InitializeComponent();
            _apexApiFacade = ApiFacade.GetInstance();
        }

        private CookieCollection _loginCookie { get; set; }
        private string _gmrid { get; set; }

        private void _addOrderBtn_Click(object sender, EventArgs e)
        {
            //HttpSender http = new HttpSender("https://fincloud.apex.com.tw/FinCloud/api/GVE/PutOrder");
            //HttpHeaderList header = new HttpHeaderList();
            //header.AddHeader("Content-Type", "application/json");
            //header.AddHeader("Host", "fincloud.apex.com.tw");
            //header.AddHeader("Referer", "https://fincloud.apex.com.tw/");
            //header.AddHeader("User-Agent",@"Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/69.0.3497.100 Safari/537.36");
            //CookieContainer cookies = new CookieContainer();
            //cookies.Add(_loginCookie);

            //string orderPriceType = "";
            //string onTrade = "";

            //if (_futureIocRdo.Checked)
            //{
            //    onTrade = "IOC";
            //    orderPriceType = "MKT";
            //}
            //else if (_futureRodRdo.Checked)
            //{
            //    onTrade = "ROD";
            //    orderPriceType = "LMT";
            //}
            //else
            //{
            //    onTrade = "FOK";
            //    orderPriceType = "LMT";
            //}


            //PutOrderPostReq req = new PutOrderPostReq
            //{
            //    assetcode = "TXFJ8.tw",
            //    bs = _futureBuyRdo.Checked ? "B" : "S",
            //    dt = _futureDayTradeChk.Checked ? 50 : 0,
            //    gmrid = this._gmrid,
            //    oct = "O",
            //    on = onTrade,
            //    ot = orderPriceType,
            //    price = _futureIocRdo.Checked ? 0 : decimal.Parse(_futurePriceTxt.Text),
            //    volume = int.Parse(_futureVolumeTxt.Text)
            //};

            //ResponseResult rsp = http.SendRequest(HttpRequestMethod.Post, JsonConvert.SerializeObject(req), header, cookies);
            //Console.Write(rsp.ResponseBody);

            FutureTradeCondition condition;
            FuturePriceType priceType;
            if (_futureIocRdo.Checked)
            {
                condition = FutureTradeCondition.IOC;
                priceType = FuturePriceType.Market;
            }
            else if (_futureRodRdo.Checked)
            {
                condition = FutureTradeCondition.ROD;
                priceType = FuturePriceType.Limit;
            }
            else
            {
                condition = FutureTradeCondition.FOK;
                priceType = FuturePriceType.Limit;
            }

            AddFutureOrder("TXFJ8.tw",
                _futureBuyRdo.Checked ? FutureBuyOrSell.Buy : FutureBuyOrSell.Sell,
                _futureDayTradeChk.Checked,
                condition,
                priceType,
                _futureIocRdo.Checked ? 0 : decimal.Parse(_futurePriceTxt.Text),
                int.Parse(_futureVolumeTxt.Text)
                );
        }

        private void _logOnBtn_Click(object sender, EventArgs e)
        {
            this._apexApiFacade.Login(_emailTxt.Text.Trim(), _pwdTxt.Text.Trim());
            var gameList = this._apexApiFacade.GetValidGmridList();
            foreach (var idObj in gameList)
            {
                this._gmridListCmb.Items.Add(new GmridCmbItem
                {
                    Text = string.Format("{0}({1})", idObj.GameName, idObj.GMRID),
                    Value = idObj.GMRID
                });
            }
            this._gmridListCmb.DisplayMember = "Text";
            this._gmridListCmb.ValueMember = "Value";
            this._gmridListCmb.SelectedIndex = 0;

            this._gmrid = ((GmridCmbItem)this._gmridListCmb.SelectedItem).Value;
            this._logOnBtn.Enabled = false;
        }

        private void _futureBuyBtn_Click(object sender, EventArgs e)
        {
            HttpSender http = new HttpSender("https://fincloud.apex.com.tw/FinCloud/api/GVE/PutOrder");
            HttpHeaderList header = new HttpHeaderList();
            header.AddHeader("Content-Type", "application/json");
            header.AddHeader("Host", "fincloud.apex.com.tw");
            header.AddHeader("Referer", "https://fincloud.apex.com.tw/");
            header.AddHeader("User-Agent", @"Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/69.0.3497.100 Safari/537.36");
            CookieContainer cookies = new CookieContainer();
            cookies.Add(_loginCookie);
            PutOrderPostReq req = new PutOrderPostReq
            {
                assetcode = "TXFJ8.tw",
                bs = "B",
                dt = 0,
                gmrid = this._gmrid,
                oct = "O",
                on = "IOC",
                ot = "MKT",
                price = 0,
                volume = 1
            };

            ResponseResult rsp = http.SendRequest(HttpRequestMethod.Post, JsonConvert.SerializeObject(req), header, cookies);
        }

        private void _futureSellBtn_Click(object sender, EventArgs e)
        {
            HttpSender http = new HttpSender("https://fincloud.apex.com.tw/FinCloud/api/GVE/PutOrder");
            HttpHeaderList header = new HttpHeaderList();
            header.AddHeader("Content-Type", "application/json");
            header.AddHeader("Host", "fincloud.apex.com.tw");
            header.AddHeader("Referer", "https://fincloud.apex.com.tw/");
            header.AddHeader("User-Agent", @"Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/69.0.3497.100 Safari/537.36");
            CookieContainer cookies = new CookieContainer();
            cookies.Add(_loginCookie);
            PutOrderPostReq req = new PutOrderPostReq
            {
                assetcode = "TXFJ8.tw", // 期貨商品(參數)
                bs = "S",//買賣(參數)
                dt = 0, //當沖單(參數)
                gmrid = this._gmrid,
                oct = "O",
                on = "IOC",//
                ot = "MKT", //限價或市價
                price = 0, //價格(參)
                volume = 1 //量(參)
            };

            ResponseResult rsp = http.SendRequest(HttpRequestMethod.Post, JsonConvert.SerializeObject(req), header, cookies);
        }

        private void AddFutureOrder(string symbol,
            FutureBuyOrSell buySell,
            bool isDayTrade,
            FutureTradeCondition condition,
            FuturePriceType priceType,
            decimal price, 
            int vol)
        {
            _apexApiFacade.SendFutureOrder(symbol,
                buySell,
                isDayTrade,
                condition,
                priceType,
                price,
                vol);
        }

        

        private void _cancelOrderBtn_Click(object sender, EventArgs e)
        {
            //HttpSender http = new HttpSender("https://fincloud.apex.com.tw/FinCloud/api/GVE/CancelOrder");
            //HttpHeaderList header = new HttpHeaderList();
            //header.AddHeader("Content-Type", "application/json");
            //header.AddHeader("Host", "fincloud.apex.com.tw");
            //header.AddHeader("Referer", "https://fincloud.apex.com.tw/");
            //header.AddHeader("User-Agent", @"Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/69.0.3497.100 Safari/537.36");
            //CookieContainer cookies = new CookieContainer();
            //cookies.Add(_loginCookie);
            //CancelOrderPostReq req = new CancelOrderPostReq
            //{
            //    country = "tw",
            //    gmrid = this._gmrid,
            //    orderId = _futureOrderCodeTxt.Text
            //};

            //ResponseResult rsp = http.SendRequest(HttpRequestMethod.Post, JsonConvert.SerializeObject(req), header, cookies);
            this._apexApiFacade.CancelOneOrder(_futureOrderCodeTxt.Text);
        }

        private void _futureOrderListBtn_Click(object sender, EventArgs e)
        {
            this._apexApiFacade.GetOrderList();
        }

        private void _futureDealLogBtn_Click(object sender, EventArgs e)
        {
            this._apexApiFacade.GetDealLog();
        }

        private void _futureErrorLogBtn_Click(object sender, EventArgs e)
        {
            this._apexApiFacade.GetErrorLog();
        }

        private void _sendStockOrderBtn_Click(object sender, EventArgs e)
        {
            StockBuyOrSell buySellType;
            if (this._stockBuyRdo.Checked)
            {
                buySellType = StockBuyOrSell.Buy;
            }
            if (this._stockSellRdo.Checked)
            {
                buySellType = StockBuyOrSell.Sell;
            }
            if (this._stockMarginBuyRdo.Checked)
            {
                buySellType = StockBuyOrSell.MarginBuy;
            }
            if (this._stockRentBuyRdo.Checked)
            {
                buySellType = StockBuyOrSell.RentBuy;
            }
            if (this._stockMarginSellRdo.Checked)
            {
                buySellType = StockBuyOrSell.MarginSell;
            }
            if (this._stockRentSellRdo.Checked)
            {
                buySellType = StockBuyOrSell.RentSell;
            }

            this._apexApiFacade.SendStockOrder(this._stockCodeTxt.Text.Trim(),
                StockBuyOrSell.Buy, 
                decimal.Parse(this._stockPriceTxt.Text),
                int.Parse(this._stockVolTxt.Text) * 1000);
        }
    }

    class GmridCmbItem
    {
        public string Text { get; set; }
        public string Value { get; set; }
    }
}
