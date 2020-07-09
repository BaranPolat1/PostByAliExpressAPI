using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressPostproductRedefiningSetgroupsResponse.
    /// </summary>
    public class AliexpressPostproductRedefiningSetgroupsResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public AeopResultDtoDomain Result { get; set; }

	/// <summary>
/// AeopResultDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeopResultDtoDomain : TopObject
{
	        /// <summary>
	        /// 错误代码
	        /// </summary>
	        [XmlElement("error_code")]
	        public long ErrorCode { get; set; }
	
	        /// <summary>
	        /// 出错时的错误信息。
	        /// </summary>
	        [XmlElement("error_message")]
	        public string ErrorMessage { get; set; }
	
	        /// <summary>
	        /// 操作结果。true/false分别表示成功和失败。
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
	
	        /// <summary>
	        /// 绑定成功的产品分组列表。
	        /// </summary>
	        [XmlArray("target_list")]
	        [XmlArrayItem("number")]
	        public List<long> TargetList { get; set; }
	
	        /// <summary>
	        /// 20150714015815415-0700
	        /// </summary>
	        [XmlElement("time_stamp")]
	        public string TimeStamp { get; set; }
}

    }
}
