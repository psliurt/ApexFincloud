using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApexCloudApi.ApiMsg
{
    public class LogOnPostRsp
    {
        public int total { get; set; }
        public bool success { get; set; }
        public string msg { get; set; }
        public List<string> items2 { get; set; }
        public List<LogOnItem1> items1 { get; set; }
    }

    public class LogOnItem1
    {
        public string UserId { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Birth { get; set; } //yyyy/MM/dd
        public string Sex { get; set; }
        public string MobilePIN { get; set; }
        public string Career { get; set; }
        public string Address { get; set; }
        public string mLevel { get; set; }
        public bool IsApproved { get; set; }
        public string Remark { get; set; }
        public string LastLoginDate { get; set; }
        public string College { get; set; }
        public string Deptment { get; set; }
        public string Occupation { get; set; }

        public List<LogOnRole> Roles { get; set; }
        public LogOnKYC KYC { get; set; }
        public string NickName { get; set; }
    }

    public class LogOnRole
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
    }

    public class LogOnKYC
    {
        public int score { get; set; }
        public int total { get; set; }
        public int type { get; set; }
    }
}
