using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.solution.schema.product.full.update
    /// </summary>
    public class AliexpressSolutionSchemaProductFullUpdateRequest : BaseTopRequest<Top.Api.Response.AliexpressSolutionSchemaProductFullUpdateResponse>
    {
        /// <summary>
        /// Product full update request. To learn how to generate the content, please refer to https://developers.aliexpress.com/en/doc.htm?docId=109760&docType=1.  Be aware that the aliexpress_product_id field should be replaced by the product ID belonged to the seller.
        /// </summary>
        public string SchemaFullUpdateRequest { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.solution.schema.product.full.update";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("schema_full_update_request", this.SchemaFullUpdateRequest);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("schema_full_update_request", this.SchemaFullUpdateRequest);
        }

        #endregion
    }
}
