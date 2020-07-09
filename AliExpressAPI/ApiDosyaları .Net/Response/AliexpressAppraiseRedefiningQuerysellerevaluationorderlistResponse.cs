using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressAppraiseRedefiningQuerysellerevaluationorderlistResponse.
    /// </summary>
    public class AliexpressAppraiseRedefiningQuerysellerevaluationorderlistResponse : TopResponse
    {
        /// <summary>
        /// 返回对象
        /// </summary>
        [XmlElement("result")]
        public RemoteQueryOpenResultDomain Result { get; set; }

	/// <summary>
/// RemoteQueryOpenResultDomain Data Structure.
/// </summary>
[Serializable]

public class RemoteQueryOpenResultDomain : TopObject
{
	        /// <summary>
	        /// 错误码
	        /// </summary>
	        [XmlElement("error_code")]
	        public long ErrorCode { get; set; }
	
	        /// <summary>
	        /// 错误信息
	        /// </summary>
	        [XmlElement("error_message")]
	        public string ErrorMessage { get; set; }
	
	        /// <summary>
	        /// 查询是否成功
	        /// </summary>
	        [XmlElement("is_success")]
	        public bool IsSuccess { get; set; }
	
	        /// <summary>
	        /// 未使用
	        /// </summary>
	        [XmlElement("object_result")]
	        public string ObjectResult { get; set; }
	
	        /// <summary>
	        /// 订单列表
	        /// </summary>
	        [XmlArray("result_list")]
	        [XmlArrayItem("json")]
	        public List<string> ResultList { get; set; }
	
	        /// <summary>
	        /// 符合条件的总订单数
	        /// </summary>
	        [XmlElement("total_item")]
	        public long TotalItem { get; set; }
}

    }
}
