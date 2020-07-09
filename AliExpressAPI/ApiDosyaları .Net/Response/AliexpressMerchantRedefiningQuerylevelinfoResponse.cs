using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressMerchantRedefiningQuerylevelinfoResponse.
    /// </summary>
    public class AliexpressMerchantRedefiningQuerylevelinfoResponse : TopResponse
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlElement("result")]
        public AeCurrentLevelInfoResponseDomain Result { get; set; }

	/// <summary>
/// AeCurrentLevelInfoDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeCurrentLevelInfoDtoDomain : TopObject
{
	        /// <summary>
	        /// 当月考核周期
	        /// </summary>
	        [XmlElement("appraise_period")]
	        public long AppraisePeriod { get; set; }
	
	        /// <summary>
	        /// 上月每日服务得分均值
	        /// </summary>
	        [XmlElement("avg_score")]
	        public string AvgScore { get; set; }
	
	        /// <summary>
	        /// 上月考核订单量
	        /// </summary>
	        [XmlElement("check_m_order_count")]
	        public long CheckMOrderCount { get; set; }
	
	        /// <summary>
	        /// 当月服务等级计算截止时间
	        /// </summary>
	        [XmlElement("end_date")]
	        public string EndDate { get; set; }
	
	        /// <summary>
	        /// 当月服务等级
	        /// </summary>
	        [XmlElement("level")]
	        public long Level { get; set; }
	
	        /// <summary>
	        /// 预估服务分得分均值
	        /// </summary>
	        [XmlElement("predict_avg_score")]
	        public string PredictAvgScore { get; set; }
	
	        /// <summary>
	        /// 下月等级预估计算截止时间
	        /// </summary>
	        [XmlElement("predict_end_date")]
	        public string PredictEndDate { get; set; }
	
	        /// <summary>
	        /// 下月预估等级
	        /// </summary>
	        [XmlElement("predict_level")]
	        public long PredictLevel { get; set; }
	
	        /// <summary>
	        /// 下月等级预估计算起始时间
	        /// </summary>
	        [XmlElement("predict_start_date")]
	        public string PredictStartDate { get; set; }
	
	        /// <summary>
	        /// 当月服务等级计算起始时间
	        /// </summary>
	        [XmlElement("start_date")]
	        public string StartDate { get; set; }
}

	/// <summary>
/// AeCurrentLevelInfoResponseDomain Data Structure.
/// </summary>
[Serializable]

public class AeCurrentLevelInfoResponseDomain : TopObject
{
	        /// <summary>
	        /// 请求失败的原因的代码
	        /// </summary>
	        [XmlElement("error_code")]
	        public string ErrorCode { get; set; }
	
	        /// <summary>
	        /// 请求失败的原因
	        /// </summary>
	        [XmlElement("error_msg")]
	        public string ErrorMsg { get; set; }
	
	        /// <summary>
	        /// 请求是否成功
	        /// </summary>
	        [XmlElement("is_success")]
	        public bool IsSuccess { get; set; }
	
	        /// <summary>
	        /// 当月服务等级的信息
	        /// </summary>
	        [XmlElement("result")]
	        public AeCurrentLevelInfoDtoDomain Result { get; set; }
}

    }
}
