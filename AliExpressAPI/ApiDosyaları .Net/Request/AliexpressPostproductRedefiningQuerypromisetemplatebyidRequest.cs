using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.postproduct.redefining.querypromisetemplatebyid
    /// </summary>
    public class AliexpressPostproductRedefiningQuerypromisetemplatebyidRequest : BaseTopRequest<Top.Api.Response.AliexpressPostproductRedefiningQuerypromisetemplatebyidResponse>
    {
        /// <summary>
        /// 输入服务模板编号。注：输入为-1时，获取所有服务模板列表。
        /// </summary>
        public Nullable<long> TemplateId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.postproduct.redefining.querypromisetemplatebyid";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("template_id", this.TemplateId);
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
