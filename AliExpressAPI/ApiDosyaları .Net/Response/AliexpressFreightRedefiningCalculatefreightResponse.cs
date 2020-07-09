using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressFreightRedefiningCalculatefreightResponse.
    /// </summary>
    public class AliexpressFreightRedefiningCalculatefreightResponse : TopResponse
    {
        /// <summary>
        /// aeopFreightCalculateResultDTOList
        /// </summary>
        [XmlArray("aeop_freight_calculate_result_d_t_o_list")]
        [XmlArrayItem("aeopfreightcalculateresultdtolist")]
        public List<AeopfreightcalculateresultdtolistDomain> AeopFreightCalculateResultDTOList { get; set; }

        /// <summary>
        /// errorDesc
        /// </summary>
        [XmlElement("result_error_desc")]
        public string ResultErrorDesc { get; set; }

        /// <summary>
        /// success
        /// </summary>
        [XmlElement("result_success")]
        public bool ResultSuccess { get; set; }

	/// <summary>
/// MoneyDomain Data Structure.
/// </summary>
[Serializable]

public class MoneyDomain : TopObject
{
	        /// <summary>
	        /// amount
	        /// </summary>
	        [XmlElement("amount")]
	        public string Amount { get; set; }
	
	        /// <summary>
	        /// cent
	        /// </summary>
	        [XmlElement("cent")]
	        public long Cent { get; set; }
	
	        /// <summary>
	        /// currencyCode
	        /// </summary>
	        [XmlElement("currency_code")]
	        public string CurrencyCode { get; set; }
}

	/// <summary>
/// AeopfreightcalculateresultdtolistDomain Data Structure.
/// </summary>
[Serializable]

public class AeopfreightcalculateresultdtolistDomain : TopObject
{
	        /// <summary>
	        /// errorCode
	        /// </summary>
	        [XmlElement("error_code")]
	        public long ErrorCode { get; set; }
	
	        /// <summary>
	        /// freight
	        /// </summary>
	        [XmlElement("freight")]
	        public MoneyDomain Freight { get; set; }
	
	        /// <summary>
	        /// serviceName
	        /// </summary>
	        [XmlElement("service_name")]
	        public string ServiceName { get; set; }
	
	        /// <summary>
	        /// standardFreight
	        /// </summary>
	        [XmlElement("standard_freight")]
	        public MoneyDomain StandardFreight { get; set; }
}

    }
}
