using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: cainiao.global.handover.cancel
    /// </summary>
    public class CainiaoGlobalHandoverCancelRequest : BaseTopRequest<Top.Api.Response.CainiaoGlobalHandoverCancelResponse>
    {
        /// <summary>
        /// ISV名称，ISV：ISV-ISV英文或拼音名称、商家ERP：SELLER-商家英文或拼音名称
        /// </summary>
        public string Client { get; set; }

        /// <summary>
        /// 要取消的交接物id，即大包id
        /// </summary>
        public Nullable<long> HandoverContentId { get; set; }

        /// <summary>
        /// 要取消的交接单id
        /// </summary>
        public Nullable<long> HandoverOrderId { get; set; }

        /// <summary>
        /// 多语言
        /// </summary>
        public string Locale { get; set; }

        /// <summary>
        /// 要取消的交接物运单号，即大包运单号
        /// </summary>
        public string TrackingNumber { get; set; }

        /// <summary>
        /// 系统自动生成
        /// </summary>
        public string UserInfo { get; set; }

        public UserInfoDtoDomain UserInfo_ { set { this.UserInfo = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "cainiao.global.handover.cancel";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("client", this.Client);
            parameters.Add("handover_content_id", this.HandoverContentId);
            parameters.Add("handover_order_id", this.HandoverOrderId);
            parameters.Add("locale", this.Locale);
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
