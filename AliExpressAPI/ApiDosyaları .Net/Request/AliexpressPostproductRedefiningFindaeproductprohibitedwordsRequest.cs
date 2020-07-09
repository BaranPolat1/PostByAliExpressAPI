using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.postproduct.redefining.findaeproductprohibitedwords
    /// </summary>
    public class AliexpressPostproductRedefiningFindaeproductprohibitedwordsRequest : BaseTopRequest<Top.Api.Response.AliexpressPostproductRedefiningFindaeproductprohibitedwordsResponse>
    {
        /// <summary>
        /// 商品类目ID
        /// </summary>
        public Nullable<long> CategoryId { get; set; }

        /// <summary>
        /// 商品的详细描述
        /// </summary>
        public string Detail { get; set; }

        /// <summary>
        /// 关键字
        /// </summary>
        public string Keywords { get; set; }

        /// <summary>
        /// 商品类目属性
        /// </summary>
        public string ProductProperties { get; set; }

        /// <summary>
        /// 商品的标题
        /// </summary>
        public string Title { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.postproduct.redefining.findaeproductprohibitedwords";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("category_id", this.CategoryId);
            parameters.Add("detail", this.Detail);
            parameters.Add("keywords", this.Keywords);
            parameters.Add("product_properties", this.ProductProperties);
            parameters.Add("title", this.Title);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateMaxListSize("keywords", this.Keywords, 200);
            RequestValidator.ValidateMaxListSize("product_properties", this.ProductProperties, 200);
        }

        #endregion
    }
}
