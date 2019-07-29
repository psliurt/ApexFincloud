using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApexCloudApi.ApiMsg.Future
{
    public class PutOrderPostRsp
    {
        public int total { get; set; }
        public bool success { get; set; }
        public string msg { get; set; }
    }
}
