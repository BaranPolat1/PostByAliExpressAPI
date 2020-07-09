using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressPostproductRedefiningQuerypromisetemplatebyidResponse.
    /// </summary>
    public class AliexpressPostproductRedefiningQuerypromisetemplatebyidResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public AeopPromiseTemplateResponseDomain Result { get; set; }

	/// <summary>
/// TemplatelistDomain Data Structure.
/// </summary>
[Serializable]

public class TemplatelistDomain : TopObject
{
	        /// <summary>
	        /// 模板id
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 模板名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
}

	/// <summary>
/// AeopPromiseTemplateResponseDomain Data Structure.
/// </summary>
[Serializable]

public class AeopPromiseTemplateResponseDomain : TopObject
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
	        /// 模板列表
	        /// </summary>
	        [XmlArray("template_list")]
	        [XmlArrayItem("templatelist")]
	        public List<TemplatelistDomain> TemplateList { get; set; }
}

    }
}
