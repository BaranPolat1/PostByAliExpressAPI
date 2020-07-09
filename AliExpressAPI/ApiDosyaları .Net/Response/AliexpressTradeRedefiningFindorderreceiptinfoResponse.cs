using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressTradeRedefiningFindorderreceiptinfoResponse.
    /// </summary>
    public class AliexpressTradeRedefiningFindorderreceiptinfoResponse : TopResponse
    {
        /// <summary>
        /// 出参
        /// </summary>
        [XmlElement("result")]
        public TpOpenAddressDtoDomain Result { get; set; }

	/// <summary>
/// TpOpenAddressDtoDomain Data Structure.
/// </summary>
[Serializable]

public class TpOpenAddressDtoDomain : TopObject
{
	        /// <summary>
	        /// 地址1
	        /// </summary>
	        [XmlElement("address")]
	        public string Address { get; set; }
	
	        /// <summary>
	        /// 地址2
	        /// </summary>
	        [XmlElement("address2")]
	        public string Address2 { get; set; }
	
	        /// <summary>
	        /// 城市
	        /// </summary>
	        [XmlElement("city")]
	        public string City { get; set; }
	
	        /// <summary>
	        /// 收件人
	        /// </summary>
	        [XmlElement("contact_person")]
	        public string ContactPerson { get; set; }
	
	        /// <summary>
	        /// 国家/地区编码
	        /// </summary>
	        [XmlElement("country")]
	        public string Country { get; set; }
	
	        /// <summary>
	        /// 国家/地区全称
	        /// </summary>
	        [XmlElement("country_name")]
	        public string CountryName { get; set; }
	
	        /// <summary>
	        /// 个人税号
	        /// </summary>
	        [XmlElement("cpf_no")]
	        public string CpfNo { get; set; }
	
	        /// <summary>
	        /// 街道详细地址
	        /// </summary>
	        [XmlElement("detail_address")]
	        public string DetailAddress { get; set; }
	
	        /// <summary>
	        /// 传真区号
	        /// </summary>
	        [XmlElement("fax_area")]
	        public string FaxArea { get; set; }
	
	        /// <summary>
	        /// 传真国家/地区码
	        /// </summary>
	        [XmlElement("fax_country")]
	        public string FaxCountry { get; set; }
	
	        /// <summary>
	        /// 传真号
	        /// </summary>
	        [XmlElement("fax_number")]
	        public string FaxNumber { get; set; }
	
	        /// <summary>
	        /// 手机
	        /// </summary>
	        [XmlElement("mobile_no")]
	        public string MobileNo { get; set; }
	
	        /// <summary>
	        /// 区号
	        /// </summary>
	        [XmlElement("phone_area")]
	        public string PhoneArea { get; set; }
	
	        /// <summary>
	        /// 国家/地区码
	        /// </summary>
	        [XmlElement("phone_country")]
	        public string PhoneCountry { get; set; }
	
	        /// <summary>
	        /// 电话
	        /// </summary>
	        [XmlElement("phone_number")]
	        public string PhoneNumber { get; set; }
	
	        /// <summary>
	        /// 省份
	        /// </summary>
	        [XmlElement("province")]
	        public string Province { get; set; }
	
	        /// <summary>
	        /// 邮编
	        /// </summary>
	        [XmlElement("zip")]
	        public string Zip { get; set; }
}

    }
}
