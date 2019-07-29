using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApexFincloud.ApiMsg
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
    }


}
