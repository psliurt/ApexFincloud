using ApexCloudApi.ApiMsg.Future;
using HttpRS;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using ApexCloudApi.ApiMsg;

namespace ApexCloudApi.Mgr
{
    public class OrderCaseManager
    {
        private static OrderCaseManager _odrCaseMgrInstance { get; set; }
        public static OrderCaseManager GetInstance(string gmrid, CookieCollection cookies, HttpHeaderList headers)
        {
            if (_odrCaseMgrInstance == null)
            {
                _odrCaseMgrInstance = new OrderCaseManager(gmrid, cookies, headers);
            }
            return _odrCaseMgrInstance;
        }

        private string _gmrid { get; set; }
        private CookieCollection _loginCookies { get; set; }
        private HttpHeaderList _header { get; set; }

        private List<string> _caseOrderIdList { get; set; }

        private string _cancelOrderApi = "https://fincloud.apex.com.tw/FinCloud/api/GVE/CancelOrder";
        private string _orderListApi = "https://fincloud.apex.com.tw/FinCloud/api/GVE/OrderList/{0}";
        private string _dealLogApi = "https://fincloud.apex.com.tw/FinCloud/api/GVE/DealLog/{0}";
        private string _errorLogApi = "https://fincloud.apex.com.tw/FinCloud/api/GVE/ErrorLog/{0}";
        private OrderCaseManager(string gmrid, CookieCollection cookies, HttpHeaderList headers)
        {
            this._gmrid = gmrid;
            this._loginCookies = cookies;
            this._header = headers;
            this._caseOrderIdList = new List<string>();
        }

        public void AddNewOrderId(string orderId)
        {
            this._caseOrderIdList.Add(orderId);
        }

        public void CancelOneOrder(string orderId)
        {
            if (this._caseOrderIdList.Contains(orderId) == false)
            {
                
            }

            HttpSender http = new HttpSender(this._cancelOrderApi);            
            CookieContainer cookies = new CookieContainer();
            cookies.Add(this._loginCookies);
            CancelOrderPostReq req = new CancelOrderPostReq
            {
                country = "tw",
                gmrid = this._gmrid,
                orderId = orderId
            };

            ResponseResult response = http.SendRequest(HttpRequestMethod.Post, JsonConvert.SerializeObject(req), this._header, cookies);
            Console.Write(response.ResponseBody);
            CancelOrderPostRsp rsp = JsonConvert.DeserializeObject<CancelOrderPostRsp>(response.ResponseBody);
        }

        public void GetOrderList()
        {
            HttpSender http = new HttpSender(string.Format(this._orderListApi, this._gmrid));
            
            CookieContainer cookies = new CookieContainer();
            cookies.Add(this._loginCookies);
            ResponseResult response = http.SendRequest(HttpRequestMethod.Get, "", this._header, cookies);
            Console.Write(response.ResponseBody);
            OrderListGetRsp rsp = JsonConvert.DeserializeObject<OrderListGetRsp>(response.ResponseBody);
        }

        public void GetDealLog()
        {
            HttpSender http = new HttpSender(string.Format(this._dealLogApi, this._gmrid));
            
            CookieContainer cookies = new CookieContainer();
            cookies.Add(this._loginCookies);

            ResponseResult response = http.SendRequest(HttpRequestMethod.Get, "", this._header, cookies);
            Console.Write(response.ResponseBody);
            DealLogGetRsp rsp = JsonConvert.DeserializeObject<DealLogGetRsp>(response.ResponseBody);
        }

        public void GetErrorLog()
        {
            HttpSender http = new HttpSender(string.Format(this._errorLogApi, this._gmrid));            
            CookieContainer cookies = new CookieContainer();
            cookies.Add(this._loginCookies);
            ResponseResult response = http.SendRequest(HttpRequestMethod.Get, "", this._header, cookies);
            Console.Write(response.ResponseBody);
            ErrorLogGetRsp rsp = JsonConvert.DeserializeObject<ErrorLogGetRsp>(response.ResponseBody);
        }
    }
}
