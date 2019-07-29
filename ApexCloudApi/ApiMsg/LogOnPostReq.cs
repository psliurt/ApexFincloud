using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApexCloudApi.ApiMsg
{
    public class LogOnPostReq
    {
        /// <summary>
        /// 帳號
        /// </summary>
        public string email { get; set; }
        /// <summary>
        /// 密碼
        /// </summary>
        public string pwd { get; set; }
    }
}
