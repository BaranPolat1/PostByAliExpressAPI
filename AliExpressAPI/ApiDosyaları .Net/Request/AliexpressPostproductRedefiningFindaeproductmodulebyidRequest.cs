using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.postproduct.redefining.findaeproductmodulebyid
    /// </summary>
    public class AliexpressPostproductRedefiningFindaeproductmodulebyidRequest : BaseTopRequest<Top.Api.Response.AliexpressPostproductRedefiningFindaeproductmodulebyidResponse>
    {
        /// <summary>
        /// moduleId 对应商品详情中的kse标签中的id属性;如: id="1004"
        /// </summary>
        public Nullable<long> ModuleId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.postproduct.redefining.findaeproductmodulebyid";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("module_id", this.ModuleId);
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
