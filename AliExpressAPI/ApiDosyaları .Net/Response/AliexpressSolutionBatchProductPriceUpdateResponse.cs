using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressSolutionBatchProductPriceUpdateResponse.
    /// </summary>
    public class AliexpressSolutionBatchProductPriceUpdateResponse : TopResponse
    {
        /// <summary>
        /// When success equals false, indicating the error code
        /// </summary>
        [XmlElement("update_error_code")]
        public string UpdateErrorCode { get; set; }

        /// <summary>
        /// When success equals false, indicating the error message
        /// </summary>
        [XmlElement("update_error_message")]
        public string UpdateErrorMessage { get; set; }

        /// <summary>
        /// update failed list
        /// </summary>
        [XmlArray("update_failed_list")]
        [XmlArrayItem("synchronize_product_response_dto")]
        public List<SynchronizeProductResponseDtoDomain> UpdateFailedList { get; set; }

        /// <summary>
        /// Indicates the update result is successful or not. Only all the products in mutiple_product_update_list have been updated successfully will make the success to be true, otherwise false.
        /// </summary>
        [XmlElement("update_success")]
        public bool UpdateSuccess { get; set; }

        /// <summary>
        /// update successful list
        /// </summary>
        [XmlArray("update_successful_list")]
        [XmlArrayItem("synchronize_product_response_dto")]
        public List<SynchronizeProductResponseDtoDomain> UpdateSuccessfulList { get; set; }

	/// <summary>
/// SynchronizeProductResponseDtoDomain Data Structure.
/// </summary>
[Serializable]

public class SynchronizeProductResponseDtoDomain : TopObject
{
	        /// <summary>
	        /// error code
	        /// </summary>
	        [XmlElement("error_code")]
	        public string ErrorCode { get; set; }
	
	        /// <summary>
	        /// error message
	        /// </summary>
	        [XmlElement("error_message")]
	        public string ErrorMessage { get; set; }
	
	        /// <summary>
	        /// product oid
	        /// </summary>
	        [XmlElement("product_id")]
	        public long ProductId { get; set; }
}

    }
}
