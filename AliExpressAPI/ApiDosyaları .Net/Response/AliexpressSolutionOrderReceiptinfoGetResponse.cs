using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressSolutionOrderReceiptinfoGetResponse.
    /// </summary>
    public class AliexpressSolutionOrderReceiptinfoGetResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public OrderAddressDtoDomain Result { get; set; }

	/// <summary>
/// OrderAddressDtoDomain Data Structure.
/// </summary>
[Serializable]

public class OrderAddressDtoDomain : TopObject
{
	        /// <summary>
	        /// address 1
	        /// </summary>
	        [XmlElement("address")]
	        public string Address { get; set; }
	
	        /// <summary>
	        /// address 2
	        /// </summary>
	        [XmlElement("address2")]
	        public string Address2 { get; set; }
	
	        /// <summary>
	        /// city
	        /// </summary>
	        [XmlElement("city")]
	        public string City { get; set; }
	
	        /// <summary>
	        /// Recipient
	        /// </summary>
	        [XmlElement("contact_person")]
	        public string ContactPerson { get; set; }
	
	        /// <summary>
	        /// country/region
	        /// </summary>
	        [XmlElement("country")]
	        public string Country { get; set; }
	
	        /// <summary>
	        /// English country/region name
	        /// </summary>
	        [XmlElement("country_name")]
	        public string CountryName { get; set; }
	
	        /// <summary>
	        /// Street detailed address
	        /// </summary>
	        [XmlElement("detail_address")]
	        public string DetailAddress { get; set; }
	
	        /// <summary>
	        /// Fax area code
	        /// </summary>
	        [XmlElement("fax_area")]
	        public string FaxArea { get; set; }
	
	        /// <summary>
	        /// Fax country/region code
	        /// </summary>
	        [XmlElement("fax_country")]
	        public string FaxCountry { get; set; }
	
	        /// <summary>
	        /// Fax number
	        /// </summary>
	        [XmlElement("fax_number")]
	        public string FaxNumber { get; set; }
	
	        /// <summary>
	        /// mobile number
	        /// </summary>
	        [XmlElement("mobile_no")]
	        public string MobileNo { get; set; }
	
	        /// <summary>
	        /// Phone area code
	        /// </summary>
	        [XmlElement("phone_area")]
	        public string PhoneArea { get; set; }
	
	        /// <summary>
	        /// Phone country/region code
	        /// </summary>
	        [XmlElement("phone_country")]
	        public string PhoneCountry { get; set; }
	
	        /// <summary>
	        /// phone number
	        /// </summary>
	        [XmlElement("phone_number")]
	        public string PhoneNumber { get; set; }
	
	        /// <summary>
	        /// province
	        /// </summary>
	        [XmlElement("province")]
	        public string Province { get; set; }
	
	        /// <summary>
	        /// Postal code
	        /// </summary>
	        [XmlElement("zip")]
	        public string Zip { get; set; }
}

    }
}
