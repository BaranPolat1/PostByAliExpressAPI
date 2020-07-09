using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressPostproductRedefiningClaimtaobaoproductsapiResponse.
    /// </summary>
    public class AliexpressPostproductRedefiningClaimtaobaoproductsapiResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public AeopTaoDaiXiaoClaimResultDtoDomain Result { get; set; }

	/// <summary>
/// AeopTaoDaiXiaoClaimResultDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeopTaoDaiXiaoClaimResultDtoDomain : TopObject
{
	        /// <summary>
	        /// 认领失败时的错误码
	        /// </summary>
	        [XmlElement("error_code")]
	        public long ErrorCode { get; set; }
	
	        /// <summary>
	        /// 认领失败时的错误信息
	        /// </summary>
	        [XmlElement("error_message")]
	        public string ErrorMessage { get; set; }
	
	        /// <summary>
	        /// 接口调用结果。true/false分别表示成功和失败。
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
