using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.message.redefining.versiontwo.querymsgdetaillistbybuyerid
    /// </summary>
    public class AliexpressMessageRedefiningVersiontwoQuerymsgdetaillistbybuyeridRequest : BaseTopRequest<Top.Api.Response.AliexpressMessageRedefiningVersiontwoQuerymsgdetaillistbybuyeridResponse>
    {
        /// <summary>
        /// 买家loginId
        /// </summary>
        public string BuyerLoginId { get; set; }

        /// <summary>
        /// 当前页数
        /// </summary>
        public Nullable<long> CurrentPage { get; set; }

        /// <summary>
        /// 商品ID或者订单ID,也可以为空
        /// </summary>
        public string ExternId { get; set; }

        /// <summary>
        /// 每页条数(pageSize取值范围(0~100) 最多返回前5000条数据)
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.message.redefining.versiontwo.querymsgdetaillistbybuyerid";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("buyer_login_id", this.BuyerLoginId);
            parameters.Add("current_page", this.CurrentPage);
            parameters.Add("extern_id", this.ExternId);
            parameters.Add("page_size", this.PageSize);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
        }

        #endregion
    }
}
