using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressLogisticsRedefiningQuerytrackingresultResponse.
    /// </summary>
    public class AliexpressLogisticsRedefiningQuerytrackingresultResponse : TopResponse
    {
        /// <summary>
        /// 追踪详细信息列表
        /// </summary>
        [XmlArray("details")]
        [XmlArrayItem("details")]
        public List<DetailsDomain> Details { get; set; }

        /// <summary>
        /// error description
        /// </summary>
        [XmlElement("error_desc")]
        public string ErrorDesc { get; set; }

        /// <summary>
        /// 追踪网址
        /// </summary>
        [XmlElement("official_website")]
        public string OfficialWebsite { get; set; }

        /// <summary>
        /// success
        /// </summary>
        [XmlElement("result_success")]
        public bool ResultSuccess { get; set; }

	/// <summary>
/// DetailsDomain Data Structure.
/// </summary>
[Serializable]

public class DetailsDomain : TopObject
{
	        /// <summary>
	        /// address
	        /// </summary>
	        [XmlElement("address")]
	        public string Address { get; set; }
	
	        /// <summary>
	        /// eventDate
	        /// </summary>
	        [XmlElement("event_date")]
	        public string EventDate { get; set; }
	
	        /// <summary>
	        /// eventDesc
	        /// </summary>
	        [XmlElement("event_desc")]
	        public string EventDesc { get; set; }
	
	        /// <summary>
	        /// signedName
	        /// </summary>
	        [XmlElement("signed_name")]
	        public string SignedName { get; set; }
	
	        /// <summary>
	        /// status
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
}

    }
}
