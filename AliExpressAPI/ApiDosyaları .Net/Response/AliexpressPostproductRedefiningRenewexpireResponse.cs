using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressPostproductRedefiningRenewexpireResponse.
    /// </summary>
    public class AliexpressPostproductRedefiningRenewexpireResponse : TopResponse
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
	        /// 错误码
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
	        /// 系统异常信息
	        /// </summary>
	        [XmlElement("error_message")]
	        public string ErrorMessage { get; set; }
	
	        /// <summary>
	        /// 是否操作成功 true/false分别代表成功失败
	        /// </summary>
	        [XmlElement("is_success")]
	        public bool IsSuccess { get; set; }
	
	        /// <summary>
	        /// 成功修改的商品个数
	        /// </summary>
	        [XmlElement("modify_count")]
	        public long ModifyCount { get; set; }
	
	        /// <summary>
	        /// 商品id
	        /// </summary>
	        [XmlElement("product_id")]
	        public long ProductId { get; set; }
}

    }
}
