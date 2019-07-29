using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApexCloudApi.ApiMsg
{
    public class ErrorLogGetRsp
    {
        public string msg { get; set; }
        public bool success { get; set; }
        public List<ErrorLogItem> items { get; set; }
    }
    public class ErrorLogItem
    {
        public string bsaction { get; set; }
        public string comment { get; set; }
        public string compcode { get; set; }
        public string gmrid { get; set; }
        public string logcode { get; set; }
        public string logdate { get; set; }
        public string logmsg { get; set; }
        public string opticombinecode { get; set; }
        public string orderno { get; set; }
        public string ordertype { get; set; }
        public string price { get; set; }
        public string volume { get; set; }
    }
}
