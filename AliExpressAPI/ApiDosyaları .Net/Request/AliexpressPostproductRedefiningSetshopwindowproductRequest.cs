using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.postproduct.redefining.setshopwindowproduct
    /// </summary>
    public class AliexpressPostproductRedefiningSetshopwindowproductRequest : BaseTopRequest<Top.Api.Response.AliexpressPostproductRedefiningSetshopwindowproductResponse>
    {
        /// <summary>
        /// 待设置橱窗的商品id，可输入多个，之前用半角分号分割。
        /// </summary>
        public string ProductIdList { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.postproduct.redefining.setshopwindowproduct";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("product_id_list", this.ProductIdList);
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
