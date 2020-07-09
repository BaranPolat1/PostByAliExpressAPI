using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.logistics.redefining.getlogisticsselleraddresses
    /// </summary>
    public class AliexpressLogisticsRedefiningGetlogisticsselleraddressesRequest : BaseTopRequest<Top.Api.Response.AliexpressLogisticsRedefiningGetlogisticsselleraddressesResponse>
    {
        /// <summary>
        /// 地址类型
        /// </summary>
        public string SellerAddressQuery { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.logistics.redefining.getlogisticsselleraddresses";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("seller_address_query", this.SellerAddressQuery);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("seller_address_query", this.SellerAddressQuery);
            RequestValidator.ValidateMaxListSize("seller_address_query", this.SellerAddressQuery, 20);
        }

        #endregion
    }
}
