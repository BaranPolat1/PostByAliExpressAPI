using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressLogisticsGetpdfsbycloudprintResponse.
    /// </summary>
    public class AliexpressLogisticsGetpdfsbycloudprintResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public AeopWaybillCloudPrintDataResponseDomain Result { get; set; }

	/// <summary>
/// CloudPrintDataDomain Data Structure.
/// </summary>
[Serializable]

public class CloudPrintDataDomain : TopObject
{
	        /// <summary>
	        /// printData
	        /// </summary>
	        [XmlElement("print_data")]
	        public string PrintData { get; set; }
	
	        /// <summary>
	        /// templateUrlList
	        /// </summary>
	        [XmlArray("template_url_list")]
	        [XmlArrayItem("string")]
	        public List<string> TemplateUrlList { get; set; }
}

	/// <summary>
/// AeopCloudPrintDataResponseDomain Data Structure.
/// </summary>
[Serializable]

public class AeopCloudPrintDataResponseDomain : TopObject
{
	        /// <summary>
	        /// cloudPrintDataList
	        /// </summary>
	        [XmlArray("cloud_print_data_list")]
	        [XmlArrayItem("cloud_print_data")]
	        public List<CloudPrintDataDomain> CloudPrintDataList { get; set; }
	
	        /// <summary>
	        /// internationalLogisticsNum
	        /// </summary>
	        [XmlElement("international_logistics_num")]
	        public string InternationalLogisticsNum { get; set; }
	
	        /// <summary>
	        /// orderCode
	        /// </summary>
	        [XmlElement("order_code")]
	        public string OrderCode { get; set; }
	
	        /// <summary>
	        /// wlWarehouseOrderId
	        /// </summary>
	        [XmlElement("wl_warehouse_order_id")]
	        public long WlWarehouseOrderId { get; set; }
}

	/// <summary>
/// AeopWaybillCloudPrintDataResponseDomain Data Structure.
/// </summary>
[Serializable]

public class AeopWaybillCloudPrintDataResponseDomain : TopObject
{
	        /// <summary>
	        /// aeopCloudPrintDataResponseList
	        /// </summary>
	        [XmlArray("aeop_cloud_print_data_response_list")]
	        [XmlArrayItem("aeop_cloud_print_data_response")]
	        public List<AeopCloudPrintDataResponseDomain> AeopCloudPrintDataResponseList { get; set; }
	
	        /// <summary>
	        /// errorCode
	        /// </summary>
	        [XmlElement("error_code")]
	        public string ErrorCode { get; set; }
	
	        /// <summary>
	        /// errorMessage
	        /// </summary>
	        [XmlElement("error_message")]
	        public string ErrorMessage { get; set; }
	
	        /// <summary>
	        /// success
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
