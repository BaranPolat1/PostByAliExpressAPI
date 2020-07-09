using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressCategoryRedefiningGetpostcategorybyidResponse.
    /// </summary>
    public class AliexpressCategoryRedefiningGetpostcategorybyidResponse : TopResponse
    {
        /// <summary>
        /// 发布类目对象
        /// </summary>
        [XmlElement("result")]
        public AeopPostCategoryResponseDomain Result { get; set; }

	/// <summary>
/// AeopPostCategoryDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeopPostCategoryDtoDomain : TopObject
{
	        /// <summary>
	        /// 类目特征的map
	        /// </summary>
	        [XmlElement("features")]
	        public string Features { get; set; }
	
	        /// <summary>
	        /// 发布类目id
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 是否叶子发布类目
	        /// </summary>
	        [XmlElement("isleaf")]
	        public bool Isleaf { get; set; }
	
	        /// <summary>
	        /// 发布类目层级
	        /// </summary>
	        [XmlElement("level")]
	        public long Level { get; set; }
	
	        /// <summary>
	        /// 发布类目多语言名称
	        /// </summary>
	        [XmlElement("names")]
	        public string Names { get; set; }
}

	/// <summary>
/// AeopPostCategoryResponseDomain Data Structure.
/// </summary>
[Serializable]

public class AeopPostCategoryResponseDomain : TopObject
{
	        /// <summary>
	        /// 发布类目
	        /// </summary>
	        [XmlArray("aeop_post_category_list")]
	        [XmlArrayItem("aeop_post_category_dto")]
	        public List<AeopPostCategoryDtoDomain> AeopPostCategoryList { get; set; }
	
	        /// <summary>
	        /// 服务调用是否成功
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
