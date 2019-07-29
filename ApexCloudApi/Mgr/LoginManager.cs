using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using HttpRS;
using Newtonsoft.Json;
using ApexCloudApi.ApiMsg;

namespace ApexCloudApi.Mgr
{
    public class LoginManager
    {
        private static LoginManager _loginMgrInstance { get; set; }

        public static LoginManager GetInstance()
        {
            if (_loginMgrInstance == null)
            {
                _loginMgrInstance = new LoginManager();
            }
            return _loginMgrInstance;
        }

        private CookieCollection _loginCookie { get; set; }
        private string _gmrid { get; set; }
        private HttpHeaderList _header { get; set; }
        private List<GmridItem> _validGmridItemList { get; set; }


        //private string _loginApi = "https://fincloud.apex.com.tw/FinCloud/api/Membership/LogOn"; //2018
        private string _loginApi = "http://www.fincloud.tw/FinCloud/api/Membership/LogOn"; //2019
        //private string _gmridApi = "https://fincloud.apex.com.tw/FinCloud/api/GVE/GetGMRIDs"; //2018
        private string _gmridApi = "http://www.fincloud.tw/FinCloud/api/GVE/GetGMRIDs"; //2019
        

        private LoginManager()
        {
            _header = new HttpHeaderList();            
            _header.AddHeader("Content-Type", "application/json");
            //_header.AddHeader("Host", "fincloud.apex.com.tw");
            _header.AddHeader("Host", "www.fincloud.tw");
            _header.AddHeader("Origin", "http://www.fincloud.tw");
            //_header.AddHeader("Referer", "https://fincloud.apex.com.tw/"); // 2018
            _header.AddHeader("Referer", "http://www.fincloud.tw/"); //2019
            _header.AddHeader("User-Agent", @"Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/69.0.3497.100 Safari/537.36");
        }

        public void Login(string email, string pwd)
        {
            HttpSender http = new HttpSender(this._loginApi);

            LogOnPostReq req = new LogOnPostReq
            {
                email = email,
                pwd = pwd
            };

            CookieContainer cookies = new CookieContainer();
            Console.Write("1:{0} 2:{1} 3:{2} 4:{3} 5:{4}", 
                this._loginApi == null ,
                http == null,
                req == null, 
                this._header == null,
                cookies == null);
            ResponseResult response = http.SendRequest(HttpRequestMethod.Post, JsonConvert.SerializeObject(req), this._header, cookies);
            this._loginCookie = response.ResponseCookieBag;
            Console.Write(response.ResponseBody);
            LogOnPostRsp rsp = JsonConvert.DeserializeObject<LogOnPostRsp>(response.ResponseBody);
            this.GetMemberGMRID();
        }

        public string GetGmrid()
        {
            return this._gmrid;
        }

        public CookieCollection GetLoginCookie()
        {
            return this._loginCookie;
        }

        public HttpHeaderList GetHttpHeader()
        {
            return this._header;
        }

        public void ChooseGmrid(string gmrid)
        {
            this._gmrid = gmrid;
        }

        public List<GmridItem> GetValidGmrid()
        {
            return this._validGmridItemList;
        }

        private void GetMemberGMRID()
        {
            HttpSender http = new HttpSender(this._gmridApi);
            CookieContainer cookies = new CookieContainer();
            cookies.Add(this._loginCookie);

            ResponseResult response = http.SendRequest(HttpRequestMethod.Get, "", this._header, cookies);
            Console.Write(response.ResponseBody);
            GetGMRIDsGetRsp rsp = JsonConvert.DeserializeObject<GetGMRIDsGetRsp>(response.ResponseBody);
            //this._gmrid = rsp.items.FirstOrDefault().GMRID;
            this._validGmridItemList = rsp.items.Where(x => x.Valid == "1").ToList();
            GmridItem validItem = this._validGmridItemList.FirstOrDefault();
            if (validItem != null)
            {
                this._gmrid = validItem.GMRID;
            }
        }        
    }
}
