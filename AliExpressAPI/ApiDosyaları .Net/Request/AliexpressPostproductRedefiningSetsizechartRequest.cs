using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.postproduct.redefining.setsizechart
    /// </summary>
    public class AliexpressPostproductRedefiningSetsizechartRequest : BaseTopRequest<Top.Api.Response.AliexpressPostproductRedefiningSetsizechartResponse>
    {
        /// <summary>
        /// 商品Id
        /// </summary>
        public Nullable<long> ProductId { get; set; }

        /// <summary>
        /// 尺码表模版Id, 必须与当前商品所在类目想对应。
        /// </summary>
        public Nullable<long> SizechartId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.postproduct.redefining.setsizechart";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("product_id", this.ProductId);
            parameters.Add("sizechart_id", this.SizechartId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
        }

        #endregion
    }
}
