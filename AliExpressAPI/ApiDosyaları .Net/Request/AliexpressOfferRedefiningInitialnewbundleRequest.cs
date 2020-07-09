using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.offer.redefining.initialnewbundle
    /// </summary>
    public class AliexpressOfferRedefiningInitialnewbundleRequest : BaseTopRequest<Top.Api.Response.AliexpressOfferRedefiningInitialnewbundleResponse>
    {
        /// <summary>
        /// 主商品ID
        /// </summary>
        public Nullable<long> MainItemId { get; set; }

        /// <summary>
        /// 搭配商品ID列表
        /// </summary>
        public string SubItemList { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.offer.redefining.initialnewbundle";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("main_item_id", this.MainItemId);
            parameters.Add("sub_item_list", this.SubItemList);
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
