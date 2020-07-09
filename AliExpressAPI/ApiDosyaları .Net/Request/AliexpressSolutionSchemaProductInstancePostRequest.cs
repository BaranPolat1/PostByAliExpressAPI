using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.solution.schema.product.instance.post
    /// </summary>
    public class AliexpressSolutionSchemaProductInstancePostRequest : BaseTopRequest<Top.Api.Response.AliexpressSolutionSchemaProductInstancePostResponse>
    {
        /// <summary>
        /// Product instance data. Please note: the shipping_template_id should be replaced with your own shipping template id, which could be obtained through  https://developers.aliexpress.com/en/doc.htm?docId=43456&docType=2
        /// </summary>
        public string ProductInstanceRequest { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.solution.schema.product.instance.post";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("product_instance_request", this.ProductInstanceRequest);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("product_instance_request", this.ProductInstanceRequest);
        }

        #endregion
    }
}
