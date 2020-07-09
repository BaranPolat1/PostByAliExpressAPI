using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.solution.batch.product.delete
    /// </summary>
    public class AliexpressSolutionBatchProductDeleteRequest : BaseTopRequest<Top.Api.Response.AliexpressSolutionBatchProductDeleteResponse>
    {
        /// <summary>
        /// maximum 100
        /// </summary>
        public string ProductIds { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.solution.batch.product.delete";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("product_ids", this.ProductIds);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateMaxListSize("product_ids", this.ProductIds, 100);
        }

        #endregion
    }
}
