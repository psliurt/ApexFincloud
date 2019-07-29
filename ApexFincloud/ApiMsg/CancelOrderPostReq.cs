using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApexFincloud.ApiMsg
{
    public class CancelOrderPostReq
    {
        public string country { get; set; }
        public string gmrid { get; set; }
        public string orderId { get; set; }
    }
}
