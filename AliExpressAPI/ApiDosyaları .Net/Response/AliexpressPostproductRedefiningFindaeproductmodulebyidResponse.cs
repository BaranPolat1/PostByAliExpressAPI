using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressPostproductRedefiningFindaeproductmodulebyidResponse.
    /// </summary>
    public class AliexpressPostproductRedefiningFindaeproductmodulebyidResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public AeopFindModuleResultDtoDomain Result { get; set; }

	/// <summary>
/// AeopFindModuleResultDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeopFindModuleResultDtoDomain : TopObject
{
	        /// <summary>
	        /// 这个模块所有者的主账户ID
	        /// </summary>
	        [XmlElement("ali_member_id")]
	        public long AliMemberId { get; set; }
	
	        /// <summary>
	        /// displayContent
	        /// </summary>
	        [XmlElement("display_content")]
	        public string DisplayContent { get; set; }
	
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
	        /// 模块的创建时间
	        /// </summary>
	        [XmlElement("gmt_create")]
	        public string GmtCreate { get; set; }
	
	        /// <summary>
	        /// 模块的最近一次修改时间
	        /// </summary>
	        [XmlElement("gmt_modified")]
	        public string GmtModified { get; set; }
	
	        /// <summary>
	        /// 模块的id
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 模块的内容
	        /// </summary>
	        [XmlElement("module_contents")]
	        public string ModuleContents { get; set; }
	
	        /// <summary>
	        /// 模块的名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 模块的状态
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
	
	        /// <summary>
	        /// 接口的调用结果。true/false分别表示成功和失败。
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
	
	        /// <summary>
	        /// 模块的类型
	        /// </summary>
	        [XmlElement("type")]
	        public string Type { get; set; }
}

    }
}
