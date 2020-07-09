using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.offer.redefining.copysizetemplate
    /// </summary>
    public class AliexpressOfferRedefiningCopysizetemplateRequest : BaseTopRequest<Top.Api.Response.AliexpressOfferRedefiningCopysizetemplateResponse>
    {
        /// <summary>
        /// 被复制的尺码模版ID
        /// </summary>
        public Nullable<long> SizeTemplateId { get; set; }

        /// <summary>
        /// 要复制到的目标叶子类目ID
        /// </summary>
        public Nullable<long> TargetLeafId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.offer.redefining.copysizetemplate";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("size_template_id", this.SizeTemplateId);
            parameters.Add("target_leaf_id", this.TargetLeafId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("size_template_id", this.SizeTemplateId);
            RequestValidator.ValidateRequired("target_leaf_id", this.TargetLeafId);
        }

        #endregion
    }
}
