using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.merchant.redefining.querydsrddisputeproductlist
    /// </summary>
    public class AliexpressMerchantRedefiningQuerydsrddisputeproductlistRequest : BaseTopRequest<Top.Api.Response.AliexpressMerchantRedefiningQuerydsrddisputeproductlistResponse>
    {
        /// <summary>
        /// 查询参数
        /// </summary>
        public string Param1 { get; set; }

        public AeDisputeExpListQueryRequestDomain Param1_ { set { this.Param1 = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.merchant.redefining.querydsrddisputeproductlist";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("param1", this.Param1);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
        }

	/// <summary>
/// AeDisputeExpListQueryRequestDomain Data Structure.
/// </summary>
[Serializable]

public class AeDisputeExpListQueryRequestDomain : TopObject
{
	        /// <summary>
	        /// 当前页
	        /// </summary>
	        [XmlElement("current_page")]
	        public Nullable<long> CurrentPage { get; set; }
	
	        /// <summary>
	        /// 语言环境
	        /// </summary>
	        [XmlElement("locale_str")]
	        public string LocaleStr { get; set; }
	
	        /// <summary>
	        /// 卖家loginId，需要与授权用户相同
	        /// </summary>
	        [XmlElement("login_id")]
	        public string LoginId { get; set; }
	
	        /// <summary>
	        /// 页内记录数
	        /// </summary>
	        [XmlElement("page_size")]
	        public Nullable<long> PageSize { get; set; }
}

        #endregion
    }
}
