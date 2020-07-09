using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressPostproductRedefiningGetsizechartinfobycategoryidResponse.
    /// </summary>
    public class AliexpressPostproductRedefiningGetsizechartinfobycategoryidResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public AeopAeProductSizeChartResultDtoDomain Result { get; set; }

	/// <summary>
/// SizechartdtolistDomain Data Structure.
/// </summary>
[Serializable]

public class SizechartdtolistDomain : TopObject
{
	        /// <summary>
	        /// 是否是系统自带的尺码模版，true表示是系统自带的，false表示用户自定义.
	        /// </summary>
	        [XmlElement("is_default")]
	        public bool IsDefault { get; set; }
	
	        /// <summary>
	        /// 尺码模版的适用类型
	        /// </summary>
	        [XmlElement("model_name")]
	        public string ModelName { get; set; }
	
	        /// <summary>
	        /// 尺码模版的名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 尺码模版ID.
	        /// </summary>
	        [XmlElement("sizechart_id")]
	        public long SizechartId { get; set; }
}

	/// <summary>
/// AeopAeProductSizeChartResultDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeopAeProductSizeChartResultDtoDomain : TopObject
{
	        /// <summary>
	        /// 错误代码
	        /// </summary>
	        [XmlElement("error_code")]
	        public long ErrorCode { get; set; }
	
	        /// <summary>
	        /// 系统异常信息
	        /// </summary>
	        [XmlElement("error_message")]
	        public string ErrorMessage { get; set; }
	
	        /// <summary>
	        /// 错误信息
	        /// </summary>
	        [XmlElement("error_msg")]
	        public string ErrorMsg { get; set; }
	
	        /// <summary>
	        /// 尺码标模版列表
	        /// </summary>
	        [XmlArray("sizechart_d_t_o_list")]
	        [XmlArrayItem("sizechartdtolist")]
	        public List<SizechartdtolistDomain> SizechartDTOList { get; set; }
	
	        /// <summary>
	        /// 调用方法成功标识，true/false分别代表成功和失败
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
