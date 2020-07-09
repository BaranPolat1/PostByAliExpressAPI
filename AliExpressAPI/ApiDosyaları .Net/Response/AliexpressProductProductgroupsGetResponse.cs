using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressProductProductgroupsGetResponse.
    /// </summary>
    public class AliexpressProductProductgroupsGetResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public AeopResultDtoDomain Result { get; set; }

	/// <summary>
/// AeopAeProductChildGroupDomain Data Structure.
/// </summary>
[Serializable]

public class AeopAeProductChildGroupDomain : TopObject
{
	        /// <summary>
	        /// 产品子分组id
	        /// </summary>
	        [XmlElement("group_id")]
	        public long GroupId { get; set; }
	
	        /// <summary>
	        /// 子分组名称
	        /// </summary>
	        [XmlElement("group_name")]
	        public string GroupName { get; set; }
}

	/// <summary>
/// AeopAeProductTreeGroupDomain Data Structure.
/// </summary>
[Serializable]

public class AeopAeProductTreeGroupDomain : TopObject
{
	        /// <summary>
	        /// 子分组列表
	        /// </summary>
	        [XmlArray("child_group_list")]
	        [XmlArrayItem("aeop_ae_product_child_group")]
	        public List<AeopAeProductChildGroupDomain> ChildGroupList { get; set; }
	
	        /// <summary>
	        /// 产品分组id
	        /// </summary>
	        [XmlElement("group_id")]
	        public long GroupId { get; set; }
	
	        /// <summary>
	        /// 分组名称
	        /// </summary>
	        [XmlElement("group_name")]
	        public string GroupName { get; set; }
}

	/// <summary>
/// AeopResultDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeopResultDtoDomain : TopObject
{
	        /// <summary>
	        /// 产品分组信息
	        /// </summary>
	        [XmlArray("target_list")]
	        [XmlArrayItem("aeop_ae_product_tree_group")]
	        public List<AeopAeProductTreeGroupDomain> TargetList { get; set; }
}

    }
}
