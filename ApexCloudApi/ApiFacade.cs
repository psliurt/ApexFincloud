using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApexCloudApi.ApiMsg;
using ApexCloudApi.Mgr;

namespace ApexCloudApi
{
    public class ApiFacade
    {
        private static ApiFacade _instance { get; set; }        
        public static ApiFacade GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ApiFacade();
            }
            return _instance;
        }

        private LoginManager _loginMgrInstance { get; set; }
        private FireOrderManager _fireOrderMgrInstance { get; set; }
        private OrderCaseManager _orderCaseMgrInstance { get; set; }

        private ApiFacade()
        {
            _loginMgrInstance = LoginManager.GetInstance();
        }

        /// <summary>
        /// 登入金融雲系統
        /// </summary>
        /// <param name="email">登入的email</param>
        /// <param name="pwd">登入的密碼</param>
        public void Login(string email, string pwd)
        {
            _loginMgrInstance.Login(email, pwd);
            _fireOrderMgrInstance =
                FireOrderManager.GetInstance(
                _loginMgrInstance.GetGmrid(),
                _loginMgrInstance.GetLoginCookie(),
                _loginMgrInstance.GetHttpHeader());

            _orderCaseMgrInstance =
                OrderCaseManager.GetInstance(
                _loginMgrInstance.GetGmrid(),
                _loginMgrInstance.GetLoginCookie(),
                _loginMgrInstance.GetHttpHeader());

        }

        public List<GmridItem> GetValidGmridList()
        {
            return _loginMgrInstance.GetValidGmrid();
        }

        public string SendStockOrder(string symbol,
            StockBuyOrSell bs,
            decimal price,
            int vol)
        {
            return _fireOrderMgrInstance.AddStockOrder(symbol, bs, price, vol);
        }

        public string SendFutureOrder(string symbol,
            FutureBuyOrSell bs,
            bool isDayTrade,
            FutureTradeCondition condition,
            FuturePriceType priceType,
            decimal price,
            int vol)
        {
            return _fireOrderMgrInstance.AddFutureOrder(symbol, bs, isDayTrade, condition, priceType, price, vol);
        }

        public string SendOptionOrder(string symbol,
            FutureBuyOrSell bs,
            FutureCloseType oc,            
            FutureTradeCondition condition,
            FuturePriceType priceType,
            decimal price,
            int vol)
        {
            return _fireOrderMgrInstance.AddOptionOrder(symbol, bs, oc, condition, priceType, price, vol);
        }

        public void CancelOneOrder(string orderId)
        {
            _orderCaseMgrInstance.CancelOneOrder(orderId);
        }

        public void GetErrorLog()
        {
            _orderCaseMgrInstance.GetErrorLog();
        }

        public void GetDealLog()
        {
            _orderCaseMgrInstance.GetDealLog();
        }

        public void GetOrderList()
        {
            _orderCaseMgrInstance.GetOrderList();
        }
    }
}
