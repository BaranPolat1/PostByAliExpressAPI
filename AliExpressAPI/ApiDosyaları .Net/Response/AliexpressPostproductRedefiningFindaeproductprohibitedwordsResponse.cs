using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressPostproductRedefiningFindaeproductprohibitedwordsResponse.
    /// </summary>
    public class AliexpressPostproductRedefiningFindaeproductprohibitedwordsResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public AeopProhibitedWordsResultDtoDomain Result { get; set; }

	/// <summary>
/// ProhibitedWordDomain Data Structure.
/// </summary>
[Serializable]

public class ProhibitedWordDomain : TopObject
{
	        /// <summary>
	        /// 违禁词名称
	        /// </summary>
	        [XmlElement("primary_word")]
	        public string PrimaryWord { get; set; }
	
	        /// <summary>
	        /// 违禁原因
	        /// </summary>
	        [XmlArray("types")]
	        [XmlArrayItem("string")]
	        public List<string> Types { get; set; }
}

	/// <summary>
/// AeopProhibitedWordsResultDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeopProhibitedWordsResultDtoDomain : TopObject
{
	        /// <summary>
	        /// 商品详描中的违禁词列表, 如果商品详描中没有违禁词, 则返回一个"'[]"。否则将以示例值中的格式返回。其中每个违禁词都包含了2个属性: primaryWord和types。其中primaryWord表示违禁词，types表示违禁词的类型，总共有四种类型: FORBIDEN_TYPE(禁用), RESTRICT_TYPE(限定), BRAND_TYPE(品牌), TORT_TYPE(侵权)。
	        /// </summary>
	        [XmlArray("detail_prohibited_words")]
	        [XmlArrayItem("prohibited_word")]
	        public List<ProhibitedWordDomain> DetailProhibitedWords { get; set; }
	
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
	        /// 关键字的违禁词列表, 如果关键字中没有违禁词, 则返回一个"'[]"。否则将以示例值中的格式返回。其中每个违禁词都包含了2个属性: primaryWord和types。其中primaryWord表示违禁词，types表示违禁词的类型，总共有四种类型: FORBIDEN_TYPE(禁用), RESTRICT_TYPE(限定), BRAND_TYPE(品牌), TORT_TYPE(侵权)。
	        /// </summary>
	        [XmlArray("keywords_prohibited_words")]
	        [XmlArrayItem("prohibited_word")]
	        public List<ProhibitedWordDomain> KeywordsProhibitedWords { get; set; }
	
	        /// <summary>
	        /// 类目属性的违禁词列表, 如果类目属性中没有违禁词, 则返回一个"'[]"。否则将以示例值中的格式返回。其中每个违禁词都包含了2个属性: primaryWord和types。其中primaryWord表示违禁词，types表示违禁词的类型，总共有四种类型: FORBIDEN_TYPE(禁用), RESTRICT_TYPE(限定), BRAND_TYPE(品牌), TORT_TYPE(侵权)。
	        /// </summary>
	        [XmlArray("product_properties_prohibited_words")]
	        [XmlArrayItem("prohibited_word")]
	        public List<ProhibitedWordDomain> ProductPropertiesProhibitedWords { get; set; }
	
	        /// <summary>
	        /// 标题中的违禁词列表, 如果标题字中没有违禁词, 则返回一个"'[]"。否则将以示例值中的格式返回。其中每个违禁词都包含了2个属性: primaryWord和types。其中primaryWord表示违禁词，types表示违禁词的类型，总共有四种类型: FORBIDEN_TYPE(禁用), RESTRICT_TYPE(限定), BRAND_TYPE(品牌), TORT_TYPE(侵权)。
	        /// </summary>
	        [XmlArray("title_prohibited_words")]
	        [XmlArrayItem("prohibited_word")]
	        public List<ProhibitedWordDomain> TitleProhibitedWords { get; set; }
}

    }
}
