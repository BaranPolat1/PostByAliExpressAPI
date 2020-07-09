using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressOfferRedefiningGetcanusedproductbysizetemplateidResponse.
    /// </summary>
    public class AliexpressOfferRedefiningGetcanusedproductbysizetemplateidResponse : TopResponse
    {
        /// <summary>
        /// 响应对象
        /// </summary>
        [XmlElement("result")]
        public AeProductQueryBySizeTemplateResponseDomain Result { get; set; }

	/// <summary>
/// AeProductQueryBySizeTemplateResponseDomain Data Structure.
/// </summary>
[Serializable]

public class AeProductQueryBySizeTemplateResponseDomain : TopObject
{
	        /// <summary>
	        /// 当前页码,从1开始
	        /// </summary>
	        [XmlElement("current_page")]
	        public long CurrentPage { get; set; }
	
	        /// <summary>
	        /// 错误码
	        /// </summary>
	        [XmlElement("error_code")]
	        public long ErrorCode { get; set; }
	
	        /// <summary>
	        /// 错误信息
	        /// </summary>
	        [XmlElement("error_message")]
	        public string ErrorMessage { get; set; }
	
	        /// <summary>
	        /// 调用是否成功
	        /// </summary>
	        [XmlElement("is_success")]
	        public bool IsSuccess { get; set; }
	
	        /// <summary>
	        /// 每页最大记录条数
	        /// </summary>
	        [XmlElement("page_size")]
	        public long PageSize { get; set; }
	
	        /// <summary>
	        /// 商品ID列表
	        /// </summary>
	        [XmlArray("product_ids")]
	        [XmlArrayItem("number")]
	        public List<long> ProductIds { get; set; }
	
	        /// <summary>
	        /// 尺码模版ID
	        /// </summary>
	        [XmlElement("size_template_id")]
	        public long SizeTemplateId { get; set; }
	
	        /// <summary>
	        /// 响应时间
	        /// </summary>
	        [XmlElement("time_stamp")]
	        public string TimeStamp { get; set; }
	
	        /// <summary>
	        /// 总记录条数
	        /// </summary>
	        [XmlElement("total")]
	        public long Total { get; set; }
}

    }
}
