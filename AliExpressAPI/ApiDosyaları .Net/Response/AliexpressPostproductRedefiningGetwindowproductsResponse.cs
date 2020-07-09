using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressPostproductRedefiningGetwindowproductsResponse.
    /// </summary>
    public class AliexpressPostproductRedefiningGetwindowproductsResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public AeopWindowProductResultDtoDomain Result { get; set; }

	/// <summary>
/// WindowproductsDomain Data Structure.
/// </summary>
[Serializable]

public class WindowproductsDomain : TopObject
{
	        /// <summary>
	        /// 橱窗的开始生效时间。
	        /// </summary>
	        [XmlElement("enabled_date")]
	        public string EnabledDate { get; set; }
	
	        /// <summary>
	        /// 橱窗的失效时间。
	        /// </summary>
	        [XmlElement("expired_date")]
	        public string ExpiredDate { get; set; }
	
	        /// <summary>
	        /// 被推荐的产品ID
	        /// </summary>
	        [XmlElement("product_id")]
	        public long ProductId { get; set; }
	
	        /// <summary>
	        /// 当前橱窗的剩余有效天数。
	        /// </summary>
	        [XmlElement("remaining_days")]
	        public long RemainingDays { get; set; }
}

	/// <summary>
/// AeopWindowProductResultDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeopWindowProductResultDtoDomain : TopObject
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
	        /// 已推荐为橱窗商品的ID列表。与windowProducts中的产品ID一致。
	        /// </summary>
	        [XmlArray("product_list")]
	        [XmlArrayItem("json")]
	        public List<string> ProductList { get; set; }
	
	        /// <summary>
	        /// 接口调用结果。true/false分别表示成功和失败。
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
	
	        /// <summary>
	        /// 已使用的橱窗个数，与windowProducts中记录的条数一致。
	        /// </summary>
	        [XmlElement("used_count")]
	        public long UsedCount { get; set; }
	
	        /// <summary>
	        /// 当前用户的橱窗总数＝已使用的橱窗数＋未使用的橱窗数。
	        /// </summary>
	        [XmlElement("window_count")]
	        public long WindowCount { get; set; }
	
	        /// <summary>
	        /// 已使用的橱窗信息。
	        /// </summary>
	        [XmlArray("window_products")]
	        [XmlArrayItem("windowproducts")]
	        public List<WindowproductsDomain> WindowProducts { get; set; }
}

    }
}
