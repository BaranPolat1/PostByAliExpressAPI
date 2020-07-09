using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.postproduct.redefining.setgroups
    /// </summary>
    public class AliexpressPostproductRedefiningSetgroupsRequest : BaseTopRequest<Top.Api.Response.AliexpressPostproductRedefiningSetgroupsResponse>
    {
        /// <summary>
        /// 商品分组ID。如果需要将一个商品设置成多个分组，需要将分组id用逗号分隔，如：'123,456,789' 至多30个。
        /// </summary>
        public string GroupIds { get; set; }

        /// <summary>
        /// 产品ID
        /// </summary>
        public Nullable<long> ProductId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.postproduct.redefining.setgroups";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("group_ids", this.GroupIds);
            parameters.Add("product_id", this.ProductId);
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
