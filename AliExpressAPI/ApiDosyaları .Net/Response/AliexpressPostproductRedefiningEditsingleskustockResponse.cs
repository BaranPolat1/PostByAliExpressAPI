using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressPostproductRedefiningEditsingleskustockResponse.
    /// </summary>
    public class AliexpressPostproductRedefiningEditsingleskustockResponse : TopResponse
    {
        /// <summary>
        /// 12345
        /// </summary>
        [XmlElement("result")]
        public AeopModifyProductResponseDomain Result { get; set; }

	/// <summary>
/// ErrorDetailDomain Data Structure.
/// </summary>
[Serializable]

public class ErrorDetailDomain : TopObject
{
	        /// <summary>
	        /// 错误代码
	        /// </summary>
	        [XmlElement("error_code")]
	        public string ErrorCode { get; set; }
	
	        /// <summary>
	        /// productIds
	        /// </summary>
	        [XmlArray("product_ids")]
	        [XmlArrayItem("number")]
	        public List<long> ProductIds { get; set; }
}

	/// <summary>
/// AeopModifyProductResponseDomain Data Structure.
/// </summary>
[Serializable]

public class AeopModifyProductResponseDomain : TopObject
{
	        /// <summary>
	        /// 错误子代码
	        /// </summary>
	        [XmlElement("error_code")]
	        public long ErrorCode { get; set; }
	
	        /// <summary>
	        /// 错误详情
	        /// </summary>
	        [XmlArray("error_details")]
	        [XmlArrayItem("error_detail")]
	        public List<ErrorDetailDomain> ErrorDetails { get; set; }
	
	        /// <summary>
	        /// 系统异常信息
	        /// </summary>
	        [XmlElement("error_message")]
	        public string ErrorMessage { get; set; }
	
	        /// <summary>
	        /// 修改的产品数
	        /// </summary>
	        [XmlElement("modify_count")]
	        public long ModifyCount { get; set; }
	
	        /// <summary>
	        /// 修改的产品ID
	        /// </summary>
	        [XmlElement("product_id")]
	        public long ProductId { get; set; }
	
	        /// <summary>
	        /// 接口调用结果。true/false分别表示成功和失败。
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
