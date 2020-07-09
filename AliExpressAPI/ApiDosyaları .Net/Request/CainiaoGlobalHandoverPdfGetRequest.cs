using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: cainiao.global.handover.pdf.get
    /// </summary>
    public class CainiaoGlobalHandoverPdfGetRequest : BaseTopRequest<Top.Api.Response.CainiaoGlobalHandoverPdfGetResponse>
    {
        /// <summary>
        /// 客户端名称，ISV：ISV-ISV英文或拼音名称、商家ERP：SELLER-商家英文或拼音名称
        /// </summary>
        public string Client { get; set; }

        /// <summary>
        /// 大包编号id
        /// </summary>
        public Nullable<long> HandoverContentId { get; set; }

        /// <summary>
        /// 多语言
        /// </summary>
        public string Locale { get; set; }

        /// <summary>
        /// 打印数据类型，1：面单、4：发货标签、512：交接清单
        /// </summary>
        public Nullable<long> Type { get; set; }

        /// <summary>
        /// 用户信息
        /// </summary>
        public string UserInfo { get; set; }

        public UserInfoDtoDomain UserInfo_ { set { this.UserInfo = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "cainiao.global.handover.pdf.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("client", this.Client);
            parameters.Add("handover_content_id", this.HandoverContentId);
            parameters.Add("locale", this.Locale);
            parameters.Add("type", this.Type);
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
            RequestValidator.ValidateRequired("handover_content_id", this.HandoverContentId);
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
