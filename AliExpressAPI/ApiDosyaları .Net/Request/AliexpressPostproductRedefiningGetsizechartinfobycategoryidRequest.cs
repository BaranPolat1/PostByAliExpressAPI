using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.postproduct.redefining.getsizechartinfobycategoryid
    /// </summary>
    public class AliexpressPostproductRedefiningGetsizechartinfobycategoryidRequest : BaseTopRequest<Top.Api.Response.AliexpressPostproductRedefiningGetsizechartinfobycategoryidResponse>
    {
        /// <summary>
        /// 商品类目Id
        /// </summary>
        public Nullable<long> CategoryId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.postproduct.redefining.getsizechartinfobycategoryid";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("category_id", this.CategoryId);
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
