using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressPostproductRedefiningCategoryforecastResponse.
    /// </summary>
    public class AliexpressPostproductRedefiningCategoryforecastResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public AeopCategoryForecastResultDtoDomain Result { get; set; }

	/// <summary>
/// AeopCategoryForecastResultDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeopCategoryForecastResultDtoDomain : TopObject
{
	        /// <summary>
	        /// 预测结果
	        /// </summary>
	        [XmlArray("category_suitability_list")]
	        [XmlArrayItem("json")]
	        public List<string> CategorySuitabilityList { get; set; }
	
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
	        /// 调用结果
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
	
	        /// <summary>
	        /// 时间戳
	        /// </summary>
	        [XmlElement("time_stamp")]
	        public string TimeStamp { get; set; }
}

    }
}
