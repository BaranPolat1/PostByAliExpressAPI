using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressOfferRedefiningGetsizetemplatesbycategoryidResponse.
    /// </summary>
    public class AliexpressOfferRedefiningGetsizetemplatesbycategoryidResponse : TopResponse
    {
        /// <summary>
        /// 响应对象
        /// </summary>
        [XmlElement("result")]
        public AeProductQuerySizeTemplateResultDtoDomain Result { get; set; }

	/// <summary>
/// AeProductSizeTemplateQuerySimpleInfoDomain Data Structure.
/// </summary>
[Serializable]

public class AeProductSizeTemplateQuerySimpleInfoDomain : TopObject
{
	        /// <summary>
	        /// 模版所属叶子类目
	        /// </summary>
	        [XmlElement("category_id")]
	        public long CategoryId { get; set; }
	
	        /// <summary>
	        /// 是否是默认模版
	        /// </summary>
	        [XmlElement("is_default")]
	        public string IsDefault { get; set; }
	
	        /// <summary>
	        /// 模型名称
	        /// </summary>
	        [XmlElement("model_name")]
	        public string ModelName { get; set; }
	
	        /// <summary>
	        /// 尺码模版名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 尺码模版ID
	        /// </summary>
	        [XmlElement("sizechart_id")]
	        public long SizechartId { get; set; }
}

	/// <summary>
/// AeProductQuerySizeTemplateResultDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeProductQuerySizeTemplateResultDtoDomain : TopObject
{
	        /// <summary>
	        /// 当前分页页数,从1开始
	        /// </summary>
	        [XmlElement("current_page")]
	        public long CurrentPage { get; set; }
	
	        /// <summary>
	        /// 响应错误码
	        /// </summary>
	        [XmlElement("error_code")]
	        public long ErrorCode { get; set; }
	
	        /// <summary>
	        /// 响应错误信息
	        /// </summary>
	        [XmlElement("error_message")]
	        public string ErrorMessage { get; set; }
	
	        /// <summary>
	        /// 调用是否成功
	        /// </summary>
	        [XmlElement("is_success")]
	        public bool IsSuccess { get; set; }
	
	        /// <summary>
	        /// 分页一页最大记录数
	        /// </summary>
	        [XmlElement("size_page")]
	        public long SizePage { get; set; }
	
	        /// <summary>
	        /// 返回查询到的尺码模版列表
	        /// </summary>
	        [XmlArray("sizechart_d_t_o_list")]
	        [XmlArrayItem("ae_product_size_template_query_simple_info")]
	        public List<AeProductSizeTemplateQuerySimpleInfoDomain> SizechartDTOList { get; set; }
	
	        /// <summary>
	        /// 响应时间
	        /// </summary>
	        [XmlElement("time_stamp")]
	        public string TimeStamp { get; set; }
	
	        /// <summary>
	        /// 本次查询总记录数
	        /// </summary>
	        [XmlElement("total")]
	        public long Total { get; set; }
}

    }
}
