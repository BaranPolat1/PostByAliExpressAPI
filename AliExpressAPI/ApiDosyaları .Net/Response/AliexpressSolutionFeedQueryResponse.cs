using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressSolutionFeedQueryResponse.
    /// </summary>
    public class AliexpressSolutionFeedQueryResponse : TopResponse
    {
        /// <summary>
        /// job id
        /// </summary>
        [XmlElement("job_id")]
        public long JobId { get; set; }

        /// <summary>
        /// Result list after all the item_content,which were previously submitted through API:aliexpress.solution.feed.submit, have been executed , including both successful and unsuccessful items.
        /// </summary>
        [XmlArray("result_list")]
        [XmlArrayItem("single_item_response_dto")]
        public List<SingleItemResponseDtoDomain> ResultList { get; set; }

        /// <summary>
        /// Count of successful items after executed under this job
        /// </summary>
        [XmlElement("success_item_count")]
        public long SuccessItemCount { get; set; }

        /// <summary>
        /// Count of total items under this job
        /// </summary>
        [XmlElement("total_item_count")]
        public long TotalItemCount { get; set; }

	/// <summary>
/// SingleItemResponseDtoDomain Data Structure.
/// </summary>
[Serializable]

public class SingleItemResponseDtoDomain : TopObject
{
	        /// <summary>
	        /// Corresponding to the item_content_id defined by the seller when invoking the API: aliexpress.solution.feed.submit
	        /// </summary>
	        [XmlElement("item_content_id")]
	        public string ItemContentId { get; set; }
	
	        /// <summary>
	        /// Execution result of each item
	        /// </summary>
	        [XmlElement("item_execution_result")]
	        public string ItemExecutionResult { get; set; }
}

    }
}
