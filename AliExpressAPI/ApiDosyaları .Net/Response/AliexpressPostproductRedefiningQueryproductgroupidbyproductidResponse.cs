using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressPostproductRedefiningQueryproductgroupidbyproductidResponse.
    /// </summary>
    public class AliexpressPostproductRedefiningQueryproductgroupidbyproductidResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public AeopResultDtoDomain Result { get; set; }

	/// <summary>
/// AeopAeProductGroupIdHolderDomain Data Structure.
/// </summary>
[Serializable]

public class AeopAeProductGroupIdHolderDomain : TopObject
{
	        /// <summary>
	        /// 产品分组ID
	        /// </summary>
	        [XmlElement("group_id")]
	        public string GroupId { get; set; }
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
	        /// 接口调用结果。true/false分别表示成功和失败。
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
	
	        /// <summary>
	        /// 这个产品所关联的产品分组ID列表。
	        /// </summary>
	        [XmlArray("target_list")]
	        [XmlArrayItem("aeop_ae_product_group_id_holder")]
	        public List<AeopAeProductGroupIdHolderDomain> TargetList { get; set; }
	
	        /// <summary>
	        /// 调用接口的时间。
	        /// </summary>
	        [XmlElement("time_stamp")]
	        public string TimeStamp { get; set; }
}

    }
}
