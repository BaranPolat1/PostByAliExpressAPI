using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: cainiao.global.handover.cloudprint.get
    /// </summary>
    public class CainiaoGlobalHandoverCloudprintGetRequest : BaseTopRequest<Top.Api.Response.CainiaoGlobalHandoverCloudprintGetResponse>
    {
        /// <summary>
        /// ISV名称，ISV：ISV-ISV英文或拼音名称、商家ERP：SELLER-商家英文或拼音名称
        /// </summary>
        public string Client { get; set; }

        /// <summary>
        /// 多语言
        /// </summary>
        public string Locale { get; set; }

        /// <summary>
        /// 大包物流单LP号
        /// </summary>
        public string OrderCode { get; set; }

        /// <summary>
        /// 大包运单号
        /// </summary>
        public string TrackingNumber { get; set; }

        /// <summary>
        /// 用户信息
        /// </summary>
        public string UserInfo { get; set; }

        public UserInfoDtoDomain UserInfo_ { set { this.UserInfo = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "cainiao.global.handover.cloudprint.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("client", this.Client);
            parameters.Add("locale", this.Locale);
            parameters.Add("order_code", this.OrderCode);
            parameters.Add("tracking_number", this.TrackingNumber);
            parameters.Add("user_info", this.UserInfo);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("client", this.Client);
            RequestValidator.ValidateRequired("order_code", this.OrderCode);
            RequestValidator.ValidateRequired("tracking_number", this.TrackingNumber);
            RequestValidator.ValidateRequired("user_info", this.UserInfo);
        }

	/// <summary>
/// UserInfoDtoDomain Data Structure.
/// </summary>
[Serializable]

public class UserInfoDtoDomain : TopObject
{
	        /// <summary>
	        /// 每个商家在ISV系统的唯一标识，一般为商家ISV账号的id
	        /// </summary>
	        [XmlElement("top_user_key")]
	        public string TopUserKey { get; set; }
}

        #endregion
    }
}
