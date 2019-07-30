using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApexCloudApi.ApiMsg
{
    public class OrderListGetRsp
    {
        public string msg { get; set; }
        public bool success { get; set; }
        public int total { get; set; }
        public List<OrderListItem> items { get; set; }
    }

    public class OrderListItem
    { 
        public string allowusercancel { get; set; }
        public string assetcode { get; set; }
        public string assetid { get; set; }
        public string bsaction { get; set; }
        public string canceltime { get; set; }
        public string comment { get; set; }
        public string compname { get; set; }
        public string comptype { get; set; }
        public string expiredate { get; set; }
        public string fromip { get; set; }
        public string gmrid { get; set; }
        public string logid { get; set; }
        public string octype { get; set; }
        public string opticombinecode { get; set; }
        public string opticombineno { get; set; }
        public string optinote { get; set; }
        public string orderid { get; set; }
        public string orderreason { get; set; }
        public string ordersource { get; set; }
        /// <summary>
        /// 0:新單 10:已經成交  20:人為取消
        /// </summary>
        public int orderstatus { get; set; }
        public string orderstatusmsg { get; set; }
        public string ordertime { get; set; }
        public string ordertype { get; set; }
        public string originalvolume { get; set; }
        public string pflassetid { get; set; }
        public string price { get; set; }
        public string usercurrency { get; set; }
        public string volume { get; set; }
    }
}
