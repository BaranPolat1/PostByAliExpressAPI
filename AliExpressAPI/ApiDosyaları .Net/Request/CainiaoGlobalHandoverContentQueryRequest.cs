using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: cainiao.global.handover.content.query
    /// </summary>
    public class CainiaoGlobalHandoverContentQueryRequest : BaseTopRequest<Top.Api.Response.CainiaoGlobalHandoverContentQueryResponse>
    {
        /// <summary>
        /// 客户端名称，ISV：ISV-ISV英文或拼音名称、商家ERP：SELLER-商家英文或拼音名称
        /// </summary>
        public string Client { get; set; }

        /// <summary>
        /// 多语言
        /// </summary>
        public string Locale { get; set; }

        /// <summary>
        /// 交接物物流订单编码,和交接物运单号参数可以任选其一即可
        /// </summary>
        public string OrderCode { get; set; }

        /// <summary>
        /// 交接物运单号，和交接物物流订单编码参数任选其一即可
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
            return "cainiao.global.handover.content.query";
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
