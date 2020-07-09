using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressPostproductRedefiningSetsizechartResponse.
    /// </summary>
    public class AliexpressPostproductRedefiningSetsizechartResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public AeopRelateSizeChartResponseDomain Result { get; set; }

	/// <summary>
/// AeopRelateSizeChartResponseDomain Data Structure.
/// </summary>
[Serializable]

public class AeopRelateSizeChartResponseDomain : TopObject
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
	        /// 设置结果。true/false分别表示成功和失败。
	        /// </summary>
	        [XmlElement("is_success")]
	        public bool IsSuccess { get; set; }
	
	        /// <summary>
	        /// 商品ID
	        /// </summary>
	        [XmlElement("product_id")]
	        public long ProductId { get; set; }
	
	        /// <summary>
	        /// 尺码表模版Id
	        /// </summary>
	        [XmlElement("sizechart_id")]
	        public long SizechartId { get; set; }
}

    }
}
