using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressSolutionFeedListGetResponse.
    /// </summary>
    public class AliexpressSolutionFeedListGetResponse : TopResponse
    {
        /// <summary>
        /// current page
        /// </summary>
        [XmlElement("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// data
        /// </summary>
        [XmlArray("job_list")]
        [XmlArrayItem("batch_operation_job_dto")]
        public List<BatchOperationJobDtoDomain> JobList { get; set; }

        /// <summary>
        /// page size
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// total count of jobs submitted for this seller
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// total page based on the total_count and page_size
        /// </summary>
        [XmlElement("total_page")]
        public long TotalPage { get; set; }

	/// <summary>
/// BatchOperationJobDtoDomain Data Structure.
/// </summary>
[Serializable]

public class BatchOperationJobDtoDomain : TopObject
{
	        /// <summary>
	        /// job id
	        /// </summary>
	        [XmlElement("job_id")]
	        public long JobId { get; set; }
	
	        /// <summary>
	        /// feed type
	        /// </summary>
	        [XmlElement("operation_type")]
	        public string OperationType { get; set; }
	
	        /// <summary>
	        /// The status of the feed
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
}

    }
}
