using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.solution.product.schema.get
    /// </summary>
    public class AliexpressSolutionProductSchemaGetRequest : BaseTopRequest<Top.Api.Response.AliexpressSolutionProductSchemaGetResponse>
    {
        /// <summary>
        /// aliexpress category id. You can get it from category API
        /// </summary>
        public Nullable<long> AliexpressCategoryId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.solution.product.schema.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("aliexpress_category_id", this.AliexpressCategoryId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("aliexpress_category_id", this.AliexpressCategoryId);
        }

        #endregion
    }
}
