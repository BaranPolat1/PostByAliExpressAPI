using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressPhotobankRedefiningListgroupResponse.
    /// </summary>
    public class AliexpressPhotobankRedefiningListgroupResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public AeopPhotoBankImageGroupResponseDomain Result { get; set; }

	/// <summary>
/// AeopPhotoBankImageGroupDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeopPhotoBankImageGroupDtoDomain : TopObject
{
	        /// <summary>
	        /// 图片分组ID
	        /// </summary>
	        [XmlElement("group_id")]
	        public string GroupId { get; set; }
	
	        /// <summary>
	        /// 图片分组名称
	        /// </summary>
	        [XmlElement("group_name")]
	        public string GroupName { get; set; }
}

	/// <summary>
/// AeopPhotoBankImageGroupResponseDomain Data Structure.
/// </summary>
[Serializable]

public class AeopPhotoBankImageGroupResponseDomain : TopObject
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
	        /// 图片银行分组列表，如果没有任何的分组信息。这个属性为:[]。
	        /// </summary>
	        [XmlArray("photo_bank_image_group_list")]
	        [XmlArrayItem("aeop_photo_bank_image_group_dto")]
	        public List<AeopPhotoBankImageGroupDtoDomain> PhotoBankImageGroupList { get; set; }
	
	        /// <summary>
	        /// 本次调用是否成功。
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
