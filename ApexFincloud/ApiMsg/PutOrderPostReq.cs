using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApexFincloud.ApiMsg
{
    /// <summary>
    /// 期貨下單
    /// </summary>
    public class PutOrderPostReq
    {
        /// <summary>
        /// 商品代碼
        /// </summary>
        public string assetcode { get; set; }
        /// <summary>
        /// B(買進), S(賣出)
        /// </summary>
        public string bs { get; set; }
        /// <summary>
        /// 當沖單(50)或非當沖單(0)
        /// </summary>
        public int dt { get; set; }
        /// <summary>
        /// 個人的登入代碼
        /// </summary>
        public string gmrid { get; set; }
        /// <summary>
        /// 倉別 O:自動   C:平倉
        /// </summary>
        public string oct { get; set; }
        /// <summary>
        /// IOC, ROD, FOK
        /// </summary>
        public string on { get; set; }
        /// <summary>
        /// LMT(限價單), MKT(市價單)
        /// </summary>
        public string ot { get; set; }
        /// <summary>
        /// 下單價格，如果ot是市價單，price可以為0，若為限價單則不可為0
        /// </summary>
        public decimal price { get; set; }
        /// <summary>
        /// 下單數量
        /// </summary>
        public int volume { get; set; }

    }
}
