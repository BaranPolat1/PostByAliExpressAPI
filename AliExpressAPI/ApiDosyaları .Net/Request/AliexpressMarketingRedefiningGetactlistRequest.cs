using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.marketing.redefining.getactlist
    /// </summary>
    public class AliexpressMarketingRedefiningGetactlistRequest : BaseTopRequest<Top.Api.Response.AliexpressMarketingRedefiningGetactlistResponse>
    {
        /// <summary>
        /// 服务入参
        /// </summary>
        public string ParamSellerCouponActivityApiQuery { get; set; }

        public SellerCouponActivityApiQueryDomain ParamSellerCouponActivityApiQuery_ { set { this.ParamSellerCouponActivityApiQuery = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.marketing.redefining.getactlist";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("param_seller_coupon_activity_api_query", this.ParamSellerCouponActivityApiQuery);
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
/// SellerCouponActivityApiQueryDomain Data Structure.
/// </summary>
[Serializable]

public class SellerCouponActivityApiQueryDomain : TopObject
{
	        /// <summary>
	        /// 活动名称，支持模糊搜索
	        /// </summary>
	        [XmlElement("activity_name")]
	        public string ActivityName { get; set; }
	
	        /// <summary>
	        /// 活动开始时间区间--最大值，允许格式："mm/dd/yyyy HH:mm:ss"
	        /// </summary>
	        [XmlElement("max_activity_start_date")]
	        public string MaxActivityStartDate { get; set; }
	
	        /// <summary>
	        /// 活动开始时间区间--最小值，允许格式"mm/dd/yyyy HH:mm:ss"
	        /// </summary>
	        [XmlElement("min_activity_start_date")]
	        public string MinActivityStartDate { get; set; }
	
	        /// <summary>
	        /// 活动状态，可取值：["not_started", "releasing", "release_end", "closed"]
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
}

        #endregion
    }
}
