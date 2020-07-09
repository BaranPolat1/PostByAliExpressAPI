using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.offer.redefining.getsizetemplatesbycategoryid
    /// </summary>
    public class AliexpressOfferRedefiningGetsizetemplatesbycategoryidRequest : BaseTopRequest<Top.Api.Response.AliexpressOfferRedefiningGetsizetemplatesbycategoryidResponse>
    {
        /// <summary>
        /// 当前页码,从1开始
        /// </summary>
        public Nullable<long> CurrentPage { get; set; }

        /// <summary>
        /// 叶子类目ID
        /// </summary>
        public Nullable<long> LeafCategoryId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.offer.redefining.getsizetemplatesbycategoryid";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("current_page", this.CurrentPage);
            parameters.Add("leaf_category_id", this.LeafCategoryId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("current_page", this.CurrentPage);
            RequestValidator.ValidateRequired("leaf_category_id", this.LeafCategoryId);
        }

        #endregion
    }
}
