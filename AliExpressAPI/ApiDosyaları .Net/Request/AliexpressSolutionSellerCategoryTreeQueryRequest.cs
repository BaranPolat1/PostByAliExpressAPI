using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.solution.seller.category.tree.query
    /// </summary>
    public class AliexpressSolutionSellerCategoryTreeQueryRequest : BaseTopRequest<Top.Api.Response.AliexpressSolutionSellerCategoryTreeQueryResponse>
    {
        /// <summary>
        /// parent category ID. To obtain the root categories, setting the category_id = 0
        /// </summary>
        public Nullable<long> CategoryId { get; set; }

        /// <summary>
        /// filter the categories which seller does not have permission
        /// </summary>
        public Nullable<bool> FilterNoPermission { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.solution.seller.category.tree.query";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("category_id", this.CategoryId);
            parameters.Add("filter_no_permission", this.FilterNoPermission);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("category_id", this.CategoryId);
            RequestValidator.ValidateRequired("filter_no_permission", this.FilterNoPermission);
        }

        #endregion
    }
}
