using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApexCloudApi.ApiMsg
{
    public class DealLogGetRsp
    {
        public int total { get; set; }
        public string msg { get; set; }
        public bool success { get; set; }
        public List<DealLogItem> items { get; set; }
    }

    public class DealLogItem
    {
        public string actmsg { get; set; }
        public string assetclearancedate { get; set; }
        public string assetcode { get; set; }
        public string assetid { get; set; }
        public string bsaction { get; set; }
        public string cashclearancedate { get; set; }
        public string closedate { get; set; }
        public string comment { get; set; }
        public string compname { get; set; }
        public string comptype { get; set; }
        public string cost { get; set; }
        public string fee { get; set; }
        public string gmrid { get; set; }
        public string logcode { get; set; }
        public string logdesc { get; set; }
        public string logid { get; set; }
        public string logmsg { get; set; }
        public string logtime { get; set; }
        public string opticombinecode { get; set; }
        public string orderlogid { get; set; }
        public string ordertype { get; set; }
        public string pflassetid { get; set; }
        public string portcreatedate { get; set; }
        public string price { get; set; }
        public string remain { get; set; }
        public string tax { get; set; }
        public string usefx { get; set; }
        public string volume { get; set; }
    }
}
