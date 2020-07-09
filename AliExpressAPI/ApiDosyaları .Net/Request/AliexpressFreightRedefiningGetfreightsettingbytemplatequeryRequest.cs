using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.freight.redefining.getfreightsettingbytemplatequery
    /// </summary>
    public class AliexpressFreightRedefiningGetfreightsettingbytemplatequeryRequest : BaseTopRequest<Top.Api.Response.AliexpressFreightRedefiningGetfreightsettingbytemplatequeryResponse>
    {
        /// <summary>
        /// Template id
        /// </summary>
        public Nullable<long> TemplateId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.freight.redefining.getfreightsettingbytemplatequery";
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
            RequestValidator.ValidateRequired("template_id", this.TemplateId);
        }

        #endregion
    }
}
