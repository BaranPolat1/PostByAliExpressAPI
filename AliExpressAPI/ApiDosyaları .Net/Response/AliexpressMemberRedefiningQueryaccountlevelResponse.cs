using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressMemberRedefiningQueryaccountlevelResponse.
    /// </summary>
    public class AliexpressMemberRedefiningQueryaccountlevelResponse : TopResponse
    {
        /// <summary>
        /// 会员等级情况
        /// </summary>
        [XmlElement("result")]
        public AccountResultDtoDomain Result { get; set; }

	/// <summary>
/// AccountResultDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AccountResultDtoDomain : TopObject
{
	        /// <summary>
	        /// 错误码
	        /// </summary>
	        [XmlElement("error_code")]
	        public string ErrorCode { get; set; }
	
	        /// <summary>
	        /// 错误信息
	        /// </summary>
	        [XmlElement("error_msg")]
	        public string ErrorMsg { get; set; }
	
	        /// <summary>
	        /// 查询是否成功
	        /// </summary>
	        [XmlElement("is_success")]
	        public bool IsSuccess { get; set; }
	
	        /// <summary>
	        /// 会员等级
	        /// </summary>
	        [XmlElement("level")]
	        public string Level { get; set; }
}

    }
}
