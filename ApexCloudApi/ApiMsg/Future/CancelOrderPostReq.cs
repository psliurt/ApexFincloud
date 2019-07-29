using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApexCloudApi.ApiMsg.Future
{
    public class CancelOrderPostReq
    {
        /// <summary>
        /// 商品的國家，目前都是tw
        /// </summary>
        public string country { get; set; }
        /// <summary>
        /// 登入者的GMRID
        /// </summary>
        public string gmrid { get; set; }
        /// <summary>
        /// 要刪單的委託單號
        /// </summary>
        public string orderId { get; set; }
    }
}
