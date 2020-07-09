using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressPostproductRedefiningFindaeproductdetailmodulelistbyqureyResponse.
    /// </summary>
    public class AliexpressPostproductRedefiningFindaeproductdetailmodulelistbyqureyResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public AeopFindModuleListResultDtoDomain Result { get; set; }

	/// <summary>
/// AeopdetailmodulelistDomain Data Structure.
/// </summary>
[Serializable]

public class AeopdetailmodulelistDomain : TopObject
{
	        /// <summary>
	        /// 卖家主账户的ID
	        /// </summary>
	        [XmlElement("ali_member_id")]
	        public long AliMemberId { get; set; }
	
	        /// <summary>
	        /// 模块的内容（已废弃）
	        /// </summary>
	        [XmlElement("display_content")]
	        public string DisplayContent { get; set; }
	
	        /// <summary>
	        /// 模块ID
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 模块的内容
	        /// </summary>
	        [XmlElement("module_contents")]
	        public string ModuleContents { get; set; }
	
	        /// <summary>
	        /// 模块名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 模块的状态
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
	
	        /// <summary>
	        /// 模块的类型
	        /// </summary>
	        [XmlElement("type")]
	        public string Type { get; set; }
}

	/// <summary>
/// AeopFindModuleListResultDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeopFindModuleListResultDtoDomain : TopObject
{
	        /// <summary>
	        /// 模块信息列表
	        /// </summary>
	        [XmlArray("aeop_detail_module_list")]
	        [XmlArrayItem("aeopdetailmodulelist")]
	        public List<AeopdetailmodulelistDomain> AeopDetailModuleList { get; set; }
	
	        /// <summary>
	        /// 当前页号
	        /// </summary>
	        [XmlElement("current_page")]
	        public long CurrentPage { get; set; }
	
	        /// <summary>
	        /// 错误代码
	        /// </summary>
	        [XmlElement("error_code")]
	        public long ErrorCode { get; set; }
	
	        /// <summary>
	        /// error_message
	        /// </summary>
	        [XmlElement("error_message")]
	        public string ErrorMessage { get; set; }
	
	        /// <summary>
	        /// 错误信息
	        /// </summary>
	        [XmlElement("error_msg")]
	        public string ErrorMsg { get; set; }
	
	        /// <summary>
	        /// 接口调用结果。true/false分别表示成功和失败。
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
	
	        /// <summary>
	        /// 总页数
	        /// </summary>
	        [XmlElement("total_page")]
	        public long TotalPage { get; set; }
}

    }
}
