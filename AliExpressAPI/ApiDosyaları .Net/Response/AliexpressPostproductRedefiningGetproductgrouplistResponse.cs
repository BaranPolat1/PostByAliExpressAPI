using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressPostproductRedefiningGetproductgrouplistResponse.
    /// </summary>
    public class AliexpressPostproductRedefiningGetproductgrouplistResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public AeopResultDtoDomain Result { get; set; }

	/// <summary>
/// AeopAeProductTreeGroupDomain Data Structure.
/// </summary>
[Serializable]

public class AeopAeProductTreeGroupDomain : TopObject
{
	        /// <summary>
	        /// 子分组id
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
/// AeopResultDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeopResultDtoDomain : TopObject
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
	        /// 接口的调用结果。true/false分别表示成功和失败。
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
	
	        /// <summary>
	        /// 产品分组信息
	        /// </summary>
	        [XmlArray("target_list")]
	        [XmlArrayItem("aeop_ae_product_tree_group")]
	        public List<AeopAeProductTreeGroupDomain> TargetList { get; set; }
	
	        /// <summary>
	        /// 调用接口的时间戳
	        /// </summary>
	        [XmlElement("time_stamp")]
	        public string TimeStamp { get; set; }
}

    }
}
