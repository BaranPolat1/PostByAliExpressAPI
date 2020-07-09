using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressPostproductRedefiningPostaeproductResponse.
    /// </summary>
    public class AliexpressPostproductRedefiningPostaeproductResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public AeopPostProductResponseDomain Result { get; set; }

	/// <summary>
/// AeopPostProductResponseDomain Data Structure.
/// </summary>
[Serializable]

public class AeopPostProductResponseDomain : TopObject
{
	        /// <summary>
	        /// 错误代码
	        /// </summary>
	        [XmlElement("error_code")]
	        public long ErrorCode { get; set; }
	
	        /// <summary>
	        /// 错误信息
	        /// </summary>
	        [XmlElement("error_message")]
	        public string ErrorMessage { get; set; }
	
	        /// <summary>
	        /// 接口调用结果。true表示发布成功，false表示发布失败。
	        /// </summary>
	        [XmlElement("is_success")]
	        public bool IsSuccess { get; set; }
	
	        /// <summary>
	        /// 新商品的ID
	        /// </summary>
	        [XmlElement("product_id")]
	        public long ProductId { get; set; }
}

    }
}
