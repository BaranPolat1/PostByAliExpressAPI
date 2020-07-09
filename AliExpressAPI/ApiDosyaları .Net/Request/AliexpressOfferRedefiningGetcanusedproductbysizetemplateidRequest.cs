using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.offer.redefining.getcanusedproductbysizetemplateid
    /// </summary>
    public class AliexpressOfferRedefiningGetcanusedproductbysizetemplateidRequest : BaseTopRequest<Top.Api.Response.AliexpressOfferRedefiningGetcanusedproductbysizetemplateidResponse>
    {
        /// <summary>
        /// 当前页码，从1开始
        /// </summary>
        public Nullable<long> CurrentPage { get; set; }

        /// <summary>
        /// 尺码模版ID
        /// </summary>
        public Nullable<long> SizeTemplateId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.offer.redefining.getcanusedproductbysizetemplateid";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("current_page", this.CurrentPage);
            parameters.Add("size_template_id", this.SizeTemplateId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("current_page", this.CurrentPage);
            RequestValidator.ValidateRequired("size_template_id", this.SizeTemplateId);
        }

        #endregion
    }
}
