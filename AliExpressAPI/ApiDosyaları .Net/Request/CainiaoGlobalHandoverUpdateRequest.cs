using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: cainiao.global.handover.update
    /// </summary>
    public class CainiaoGlobalHandoverUpdateRequest : BaseTopRequest<Top.Api.Response.CainiaoGlobalHandoverUpdateResponse>
    {
        /// <summary>
        /// ISV名称，ISV：ISV-ISV英文或拼音名称、商家ERP：SELLER-商家英文或拼音名称
        /// </summary>
        public string Client { get; set; }

        /// <summary>
        /// 交接单id
        /// </summary>
        public Nullable<long> HandoverOrderId { get; set; }

        /// <summary>
        /// 多语言
        /// </summary>
        public string Locale { get; set; }

        /// <summary>
        /// 要创建交接单的小包编码集合，数量上限200
        /// </summary>
        public string OrderCodeList { get; set; }

        /// <summary>
        /// 揽收信息
        /// </summary>
        public string PickupInfo { get; set; }

        public PickupDtoDomain PickupInfo_ { set { this.PickupInfo = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 大包备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 退件信息
        /// </summary>
        public string ReturnInfo { get; set; }

        public ReturnerDtoDomain ReturnInfo_ { set { this.ReturnInfo = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 交接单类型，菜鸟揽收(cainiao_pickup)或自寄(self_post)，默认菜鸟揽收
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 用户信息
        /// </summary>
        public string UserInfo { get; set; }

        public UserInfoDtoDomain UserInfo_ { set { this.UserInfo = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 大包重量
        /// </summary>
        public Nullable<long> Weight { get; set; }

        /// <summary>
        /// 重量单位，克:g, 千克:kg，默认g
        /// </summary>
        public string WeightUnit { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "cainiao.global.handover.update";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("client", this.Client);
            parameters.Add("handover_order_id", this.HandoverOrderId);
            parameters.Add("locale", this.Locale);
            parameters.Add("order_code_list", this.OrderCodeList);
            parameters.Add("pickup_info", this.PickupInfo);
            parameters.Add("remark", this.Remark);
            parameters.Add("return_info", this.ReturnInfo);
            parameters.Add("type", this.Type);
            parameters.Add("user_info", this.UserInfo);
            parameters.Add("weight", this.Weight);
            parameters.Add("weight_unit", this.WeightUnit);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("client", this.Client);
            RequestValidator.ValidateRequired("handover_order_id", this.HandoverOrderId);
            RequestValidator.ValidateRequired("order_code_list", this.OrderCodeList);
            RequestValidator.ValidateMaxListSize("order_code_list", this.OrderCodeList, 200);
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

	/// <summary>
/// AddressDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AddressDtoDomain : TopObject
{
	        /// <summary>
	        /// 市
	        /// </summary>
	        [XmlElement("city")]
	        public string City { get; set; }
	
	        /// <summary>
	        /// 国家
	        /// </summary>
	        [XmlElement("country")]
	        public string Country { get; set; }
	
	        /// <summary>
	        /// 详细地址
	        /// </summary>
	        [XmlElement("detail_address")]
	        public string DetailAddress { get; set; }
	
	        /// <summary>
	        /// 区
	        /// </summary>
	        [XmlElement("district")]
	        public string District { get; set; }
	
	        /// <summary>
	        /// 省
	        /// </summary>
	        [XmlElement("province")]
	        public string Province { get; set; }
	
	        /// <summary>
	        /// 街道
	        /// </summary>
	        [XmlElement("street")]
	        public string Street { get; set; }
	
	        /// <summary>
	        /// 邮编
	        /// </summary>
	        [XmlElement("zip_code")]
	        public string ZipCode { get; set; }
}

	/// <summary>
/// ReturnerDtoDomain Data Structure.
/// </summary>
[Serializable]

public class ReturnerDtoDomain : TopObject
{
	        /// <summary>
	        /// 退件地址
	        /// </summary>
	        [XmlElement("address")]
	        public AddressDtoDomain Address { get; set; }
	
	        /// <summary>
	        /// AE后台维护的退件地址ID
	        /// </summary>
	        [XmlElement("address_id")]
	        public Nullable<long> AddressId { get; set; }
	
	        /// <summary>
	        /// 邮箱
	        /// </summary>
	        [XmlElement("email")]
	        public string Email { get; set; }
	
	        /// <summary>
	        /// 移动电话, 校验格式：^1(3|4|5|6|7|8|9)\d{9}$
	        /// </summary>
	        [XmlElement("mobile")]
	        public string Mobile { get; set; }
	
	        /// <summary>
	        /// 退件联系人名称，必须包含中文字符
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 固定电话，可空，校验格式：(^0[\d]{2,3}-[\d]{7,8}$)|(^400[\d]{3,4}[\d]{3,4}$)|(400-[\d]{3,4}-[\d]{3,4}$)
	        /// </summary>
	        [XmlElement("phone")]
	        public string Phone { get; set; }
}

	/// <summary>
/// PickupDtoDomain Data Structure.
/// </summary>
[Serializable]

public class PickupDtoDomain : TopObject
{
	        /// <summary>
	        /// 揽收地址
	        /// </summary>
	        [XmlElement("address")]
	        public AddressDtoDomain Address { get; set; }
	
	        /// <summary>
	        /// AE后台维护的发件地址ID
	        /// </summary>
	        [XmlElement("address_id")]
	        public Nullable<long> AddressId { get; set; }
	
	        /// <summary>
	        /// 邮箱
	        /// </summary>
	        [XmlElement("email")]
	        public string Email { get; set; }
	
	        /// <summary>
	        /// 移动电话, 校验格式：^1(3|4|5|6|7|8|9)\d{9}$
	        /// </summary>
	        [XmlElement("mobile")]
	        public string Mobile { get; set; }
	
	        /// <summary>
	        /// 揽收联系人名称，必须包含中文字符
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 固定电话，可空，校验格式：(^0[\d]{2,3}-[\d]{7,8}$)|(^400[\d]{3,4}[\d]{3,4}$)|(400-[\d]{3,4}-[\d]{3,4}$)
	        /// </summary>
	        [XmlElement("phone")]
	        public string Phone { get; set; }
}

        #endregion
    }
}
