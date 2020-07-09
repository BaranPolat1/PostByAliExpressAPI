using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressLogisticsRedefiningGetfieldinfoforprintResponse.
    /// </summary>
    public class AliexpressLogisticsRedefiningGetfieldinfoforprintResponse : TopResponse
    {
        /// <summary>
        /// 12345
        /// </summary>
        [XmlElement("result")]
        public AeopWarehouseOrderPrintFieldResponseDomain Result { get; set; }

	/// <summary>
/// AeopWarehouseOrderPrintFieldResponseDomain Data Structure.
/// </summary>
[Serializable]

public class AeopWarehouseOrderPrintFieldResponseDomain : TopObject
{
	        /// <summary>
	        /// Call the error description message
	        /// </summary>
	        [XmlElement("error_desc")]
	        public string ErrorDesc { get; set; }
	
	        /// <summary>
	        /// PresortingCode
	        /// </summary>
	        [XmlElement("presorting_code")]
	        public string PresortingCode { get; set; }
	
	        /// <summary>
	        /// Whether to print the sort code
	        /// </summary>
	        [XmlElement("print_presorting")]
	        public bool PrintPresorting { get; set; }
	
	        /// <summary>
	        /// success
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
	
	        /// <summary>
	        /// Transaction order number
	        /// </summary>
	        [XmlElement("trade_order_id")]
	        public long TradeOrderId { get; set; }
	
	        /// <summary>
	        /// Partition code
	        /// </summary>
	        [XmlElement("zoning_code")]
	        public string ZoningCode { get; set; }
}

    }
}
