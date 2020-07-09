using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressPostproductRedefiningEditaeproductResponse.
    /// </summary>
    public class AliexpressPostproductRedefiningEditaeproductResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public AeopModifyProductResponseDomain Result { get; set; }

	/// <summary>
/// AeopModifyProductResponseDomain Data Structure.
/// </summary>
[Serializable]

public class AeopModifyProductResponseDomain : TopObject
{
	        /// <summary>
	        /// 错误代码
	        /// </summary>
	        [XmlElement("error_code")]
	        public long ErrorCode { get; set; }
	
	        /// <summary>
	        /// 错误详情
	        /// </summary>
	        [XmlArray("error_details")]
	        [XmlArrayItem("json")]
	        public List<string> ErrorDetails { get; set; }
	
	        /// <summary>
	        /// 错误信息
	        /// </summary>
	        [XmlElement("error_message")]
	        public string ErrorMessage { get; set; }
	
	        /// <summary>
	        /// 接口调用结果。成功为true，失败为false。
	        /// </summary>
	        [XmlElement("is_success")]
	        public bool IsSuccess { get; set; }
	
	        /// <summary>
	        /// 编辑成功次数。对于编辑商品来说，这个参数为1。
	        /// </summary>
	        [XmlElement("modify_count")]
	        public long ModifyCount { get; set; }
	
	        /// <summary>
	        /// 商品的ID。
	        /// </summary>
	        [XmlElement("product_id")]
	        public long ProductId { get; set; }
}

    }
}
