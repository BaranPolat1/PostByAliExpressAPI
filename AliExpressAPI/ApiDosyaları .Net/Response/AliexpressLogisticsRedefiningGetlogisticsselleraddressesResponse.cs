using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressLogisticsRedefiningGetlogisticsselleraddressesResponse.
    /// </summary>
    public class AliexpressLogisticsRedefiningGetlogisticsselleraddressesResponse : TopResponse
    {
        /// <summary>
        /// 12345
        /// </summary>
        [XmlElement("error_desc")]
        public string ErrorDesc { get; set; }

        /// <summary>
        /// 12345
        /// </summary>
        [XmlArray("pickup_seller_address_list")]
        [XmlArrayItem("pickupselleraddresslist")]
        public List<PickupselleraddresslistDomain> PickupSellerAddressList { get; set; }

        /// <summary>
        /// 12345
        /// </summary>
        [XmlArray("refund_seller_address_list")]
        [XmlArrayItem("refundselleraddresslist")]
        public List<RefundselleraddresslistDomain> RefundSellerAddressList { get; set; }

        /// <summary>
        /// 12345
        /// </summary>
        [XmlElement("result_error_code")]
        public long ResultErrorCode { get; set; }

        /// <summary>
        /// success
        /// </summary>
        [XmlElement("result_success")]
        public bool ResultSuccess { get; set; }

        /// <summary>
        /// 12345
        /// </summary>
        [XmlArray("sender_seller_address_list")]
        [XmlArrayItem("senderselleraddresslist")]
        public List<SenderselleraddresslistDomain> SenderSellerAddressList { get; set; }

	/// <summary>
/// SenderselleraddresslistDomain Data Structure.
/// </summary>
[Serializable]

public class SenderselleraddresslistDomain : TopObject
{
	        /// <summary>
	        /// addressId
	        /// </summary>
	        [XmlElement("address_id")]
	        public long AddressId { get; set; }
	
	        /// <summary>
	        /// city
	        /// </summary>
	        [XmlElement("city")]
	        public string City { get; set; }
	
	        /// <summary>
	        /// country
	        /// </summary>
	        [XmlElement("country")]
	        public string Country { get; set; }
	
	        /// <summary>
	        /// county
	        /// </summary>
	        [XmlElement("county")]
	        public string County { get; set; }
	
	        /// <summary>
	        /// email
	        /// </summary>
	        [XmlElement("email")]
	        public string Email { get; set; }
	
	        /// <summary>
	        /// fax
	        /// </summary>
	        [XmlElement("fax")]
	        public string Fax { get; set; }
	
	        /// <summary>
	        /// isDefault
	        /// </summary>
	        [XmlElement("is_default")]
	        public long IsDefault { get; set; }
	
	        /// <summary>
	        /// language
	        /// </summary>
	        [XmlElement("language")]
	        public string Language { get; set; }
	
	        /// <summary>
	        /// memberType
	        /// </summary>
	        [XmlElement("member_type")]
	        public string MemberType { get; set; }
	
	        /// <summary>
	        /// mobile
	        /// </summary>
	        [XmlElement("mobile")]
	        public string Mobile { get; set; }
	
	        /// <summary>
	        /// name
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// NeedToUpdate
	        /// </summary>
	        [XmlElement("need_to_update")]
	        public bool NeedToUpdate { get; set; }
	
	        /// <summary>
	        /// phone
	        /// </summary>
	        [XmlElement("phone")]
	        public string Phone { get; set; }
	
	        /// <summary>
	        /// postcode
	        /// </summary>
	        [XmlElement("postcode")]
	        public string Postcode { get; set; }
	
	        /// <summary>
	        /// province
	        /// </summary>
	        [XmlElement("province")]
	        public string Province { get; set; }
	
	        /// <summary>
	        /// street
	        /// </summary>
	        [XmlElement("street")]
	        public string Street { get; set; }
	
	        /// <summary>
	        /// streetAddress
	        /// </summary>
	        [XmlElement("street_address")]
	        public string StreetAddress { get; set; }
	
	        /// <summary>
	        /// trademanageId
	        /// </summary>
	        [XmlElement("trademanage_id")]
	        public string TrademanageId { get; set; }
}

	/// <summary>
/// RefundselleraddresslistDomain Data Structure.
/// </summary>
[Serializable]

public class RefundselleraddresslistDomain : TopObject
{
	        /// <summary>
	        /// addressId
	        /// </summary>
	        [XmlElement("address_id")]
	        public long AddressId { get; set; }
	
	        /// <summary>
	        /// city
	        /// </summary>
	        [XmlElement("city")]
	        public string City { get; set; }
	
	        /// <summary>
	        /// country
	        /// </summary>
	        [XmlElement("country")]
	        public string Country { get; set; }
	
	        /// <summary>
	        /// county
	        /// </summary>
	        [XmlElement("county")]
	        public string County { get; set; }
	
	        /// <summary>
	        /// email
	        /// </summary>
	        [XmlElement("email")]
	        public string Email { get; set; }
	
	        /// <summary>
	        /// fax
	        /// </summary>
	        [XmlElement("fax")]
	        public string Fax { get; set; }
	
	        /// <summary>
	        /// isDefault
	        /// </summary>
	        [XmlElement("is_default")]
	        public long IsDefault { get; set; }
	
	        /// <summary>
	        /// language
	        /// </summary>
	        [XmlElement("language")]
	        public string Language { get; set; }
	
	        /// <summary>
	        /// memberType
	        /// </summary>
	        [XmlElement("member_type")]
	        public string MemberType { get; set; }
	
	        /// <summary>
	        /// mobile
	        /// </summary>
	        [XmlElement("mobile")]
	        public string Mobile { get; set; }
	
	        /// <summary>
	        /// name
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// NeedToUpdate
	        /// </summary>
	        [XmlElement("need_to_update")]
	        public bool NeedToUpdate { get; set; }
	
	        /// <summary>
	        /// phone
	        /// </summary>
	        [XmlElement("phone")]
	        public string Phone { get; set; }
	
	        /// <summary>
	        /// postcode
	        /// </summary>
	        [XmlElement("postcode")]
	        public string Postcode { get; set; }
	
	        /// <summary>
	        /// province
	        /// </summary>
	        [XmlElement("province")]
	        public string Province { get; set; }
	
	        /// <summary>
	        /// street
	        /// </summary>
	        [XmlElement("street")]
	        public string Street { get; set; }
	
	        /// <summary>
	        /// streetAddress
	        /// </summary>
	        [XmlElement("street_address")]
	        public string StreetAddress { get; set; }
	
	        /// <summary>
	        /// trademanageId
	        /// </summary>
	        [XmlElement("trademanage_id")]
	        public string TrademanageId { get; set; }
}

	/// <summary>
/// PickupselleraddresslistDomain Data Structure.
/// </summary>
[Serializable]

public class PickupselleraddresslistDomain : TopObject
{
	        /// <summary>
	        /// addressId
	        /// </summary>
	        [XmlElement("address_id")]
	        public long AddressId { get; set; }
	
	        /// <summary>
	        /// city
	        /// </summary>
	        [XmlElement("city")]
	        public string City { get; set; }
	
	        /// <summary>
	        /// country
	        /// </summary>
	        [XmlElement("country")]
	        public string Country { get; set; }
	
	        /// <summary>
	        /// county
	        /// </summary>
	        [XmlElement("county")]
	        public string County { get; set; }
	
	        /// <summary>
	        /// email
	        /// </summary>
	        [XmlElement("email")]
	        public string Email { get; set; }
	
	        /// <summary>
	        /// fax
	        /// </summary>
	        [XmlElement("fax")]
	        public string Fax { get; set; }
	
	        /// <summary>
	        /// isDefault
	        /// </summary>
	        [XmlElement("is_default")]
	        public long IsDefault { get; set; }
	
	        /// <summary>
	        /// language
	        /// </summary>
	        [XmlElement("language")]
	        public string Language { get; set; }
	
	        /// <summary>
	        /// memberType
	        /// </summary>
	        [XmlElement("member_type")]
	        public string MemberType { get; set; }
	
	        /// <summary>
	        /// mobile
	        /// </summary>
	        [XmlElement("mobile")]
	        public string Mobile { get; set; }
	
	        /// <summary>
	        /// name
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// NeedToUpdate
	        /// </summary>
	        [XmlElement("need_to_update")]
	        public bool NeedToUpdate { get; set; }
	
	        /// <summary>
	        /// phone
	        /// </summary>
	        [XmlElement("phone")]
	        public string Phone { get; set; }
	
	        /// <summary>
	        /// postcode
	        /// </summary>
	        [XmlElement("postcode")]
	        public string Postcode { get; set; }
	
	        /// <summary>
	        /// province
	        /// </summary>
	        [XmlElement("province")]
	        public string Province { get; set; }
	
	        /// <summary>
	        /// street
	        /// </summary>
	        [XmlElement("street")]
	        public string Street { get; set; }
	
	        /// <summary>
	        /// streetAddress
	        /// </summary>
	        [XmlElement("street_address")]
	        public string StreetAddress { get; set; }
	
	        /// <summary>
	        /// trademanageId
	        /// </summary>
	        [XmlElement("trademanage_id")]
	        public string TrademanageId { get; set; }
}

    }
}
