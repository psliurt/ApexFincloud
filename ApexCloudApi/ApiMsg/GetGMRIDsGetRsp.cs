using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApexCloudApi.ApiMsg
{
    public class GetGMRIDsGetRsp
    {
        public int total { get; set; }
        public bool success { get; set; }
        public string msg { get; set; }
        public List<GmridItem> items { get; set; }
    }

    public class GmridItem
    {
        public string GameName { get; set; }
        public string GameCode { get; set; }
        public string GMRID { get; set; }
        /// <summary>
        /// format 8/30/2019 12:00:00 AM
        /// </summary>
        public string DueDate { get; set; }
        /// <summary>
        /// 有效為1 過期無效為-1
        /// </summary>
        public string Valid { get; set; }
    }
}
