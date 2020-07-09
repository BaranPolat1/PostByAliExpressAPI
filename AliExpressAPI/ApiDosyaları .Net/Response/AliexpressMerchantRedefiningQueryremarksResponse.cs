using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressMerchantRedefiningQueryremarksResponse.
    /// </summary>
    public class AliexpressMerchantRedefiningQueryremarksResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public ResultDomain Result { get; set; }

	/// <summary>
/// DataDomain Data Structure.
/// </summary>
[Serializable]

public class DataDomain : TopObject
{
	        /// <summary>
	        /// content
	        /// </summary>
	        [XmlElement("content")]
	        public string Content { get; set; }
	
	        /// <summary>
	        /// remarkId
	        /// </summary>
	        [XmlElement("remark_id")]
	        public long RemarkId { get; set; }
}

	/// <summary>
/// ResultDomain Data Structure.
/// </summary>
[Serializable]

public class ResultDomain : TopObject
{
	        /// <summary>
	        /// data
	        /// </summary>
	        [XmlArray("datas")]
	        [XmlArrayItem("data")]
	        public List<DataDomain> Datas { get; set; }
	
	        /// <summary>
	        /// errorCode
	        /// </summary>
	        [XmlElement("error_code")]
	        public long ErrorCode { get; set; }
}

    }
}
