using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressMerchantRedefiningQueryservicescoreinfoResponse.
    /// </summary>
    public class AliexpressMerchantRedefiningQueryservicescoreinfoResponse : TopResponse
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlElement("result")]
        public AeStoreServiceScoreInfoResponseDomain Result { get; set; }

	/// <summary>
/// AeIndustryAvgServiceIndexDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeIndustryAvgServiceIndexDtoDomain : TopObject
{
	        /// <summary>
	        /// 拍而不卖率
	        /// </summary>
	        [XmlElement("buy_not_sel_rate")]
	        public string BuyNotSelRate { get; set; }
	
	        /// <summary>
	        /// DSR卖家服务评价综合评分
	        /// </summary>
	        [XmlElement("dsr_communicate_score")]
	        public string DsrCommunicateScore { get; set; }
	
	        /// <summary>
	        /// DSR物流服务评价综合评分（免责后）
	        /// </summary>
	        [XmlElement("dsr_logis_score_aft_disclaim")]
	        public string DsrLogisScoreAftDisclaim { get; set; }
	
	        /// <summary>
	        /// DSR商品评价综合评分
	        /// </summary>
	        [XmlElement("dsr_prod_score")]
	        public string DsrProdScore { get; set; }
	
	        /// <summary>
	        /// 免责后未收到货纠纷发起率
	        /// </summary>
	        [XmlElement("nr_disclaimer_issue_rate")]
	        public string NrDisclaimerIssueRate { get; set; }
	
	        /// <summary>
	        /// 发布类目层级
	        /// </summary>
	        [XmlElement("pcate_flag")]
	        public long PcateFlag { get; set; }
	
	        /// <summary>
	        /// 发布类目id
	        /// </summary>
	        [XmlElement("pcate_id")]
	        public long PcateId { get; set; }
	
	        /// <summary>
	        /// 免责后货不对版纠纷发起率
	        /// </summary>
	        [XmlElement("snad_disclaimer_issue_rate")]
	        public string SnadDisclaimerIssueRate { get; set; }
}

	/// <summary>
/// AeServiceIndexDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeServiceIndexDtoDomain : TopObject
{
	        /// <summary>
	        /// 拍而不卖率
	        /// </summary>
	        [XmlElement("buy_not_sel_rate")]
	        public string BuyNotSelRate { get; set; }
	
	        /// <summary>
	        /// DSR卖家服务评价综合评分
	        /// </summary>
	        [XmlElement("dsr_communicate_score")]
	        public string DsrCommunicateScore { get; set; }
	
	        /// <summary>
	        /// DSR物流服务评价综合评分（免责后）
	        /// </summary>
	        [XmlElement("dsr_logis_score_aft_disclaim")]
	        public string DsrLogisScoreAftDisclaim { get; set; }
	
	        /// <summary>
	        /// DSR商品评价综合评分
	        /// </summary>
	        [XmlElement("dsr_prod_score")]
	        public string DsrProdScore { get; set; }
	
	        /// <summary>
	        /// 48小时发货率(不考核)
	        /// </summary>
	        [XmlElement("logis48h_send_goods_rate")]
	        public string Logis48hSendGoodsRate { get; set; }
	
	        /// <summary>
	        /// 免责后未收到货纠纷发起率分子父订单数
	        /// </summary>
	        [XmlElement("nr_disclaimer_issue_mord_cnt")]
	        public long NrDisclaimerIssueMordCnt { get; set; }
	
	        /// <summary>
	        /// 免责后未收到货纠纷发起率
	        /// </summary>
	        [XmlElement("nr_disclaimer_issue_rate")]
	        public string NrDisclaimerIssueRate { get; set; }
	
	        /// <summary>
	        /// 免责前未收到货纠纷发起率分子父订单数
	        /// </summary>
	        [XmlElement("nr_issue_mord_cnt")]
	        public long NrIssueMordCnt { get; set; }
	
	        /// <summary>
	        /// 免责后货不对版纠纷发起率分子父订单数
	        /// </summary>
	        [XmlElement("snad_disclaimer_issue_mord_cnt")]
	        public long SnadDisclaimerIssueMordCnt { get; set; }
	
	        /// <summary>
	        /// 免责后货不对版纠纷发起率
	        /// </summary>
	        [XmlElement("snad_disclaimer_issue_rate")]
	        public string SnadDisclaimerIssueRate { get; set; }
	
	        /// <summary>
	        /// 免责前货不对版纠纷发起率分子父订单数
	        /// </summary>
	        [XmlElement("snad_issue_mord_cnt")]
	        public long SnadIssueMordCnt { get; set; }
}

	/// <summary>
/// AeIndustryAvgServiceScoreDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeIndustryAvgServiceScoreDtoDomain : TopObject
{
	        /// <summary>
	        /// 拍而不卖率得分
	        /// </summary>
	        [XmlElement("buy_not_sel_score")]
	        public string BuyNotSelScore { get; set; }
	
	        /// <summary>
	        /// dsr卖家服务得分
	        /// </summary>
	        [XmlElement("dsr_communicate_score")]
	        public string DsrCommunicateScore { get; set; }
	
	        /// <summary>
	        /// dsr物流得分
	        /// </summary>
	        [XmlElement("dsr_logis_score")]
	        public string DsrLogisScore { get; set; }
	
	        /// <summary>
	        /// dsr商品描述得分
	        /// </summary>
	        [XmlElement("dsr_prod_score")]
	        public string DsrProdScore { get; set; }
	
	        /// <summary>
	        /// nr纠纷提起率得分
	        /// </summary>
	        [XmlElement("nr_issue_score")]
	        public string NrIssueScore { get; set; }
	
	        /// <summary>
	        /// 发布类目层级
	        /// </summary>
	        [XmlElement("pcate_flag")]
	        public long PcateFlag { get; set; }
	
	        /// <summary>
	        /// 发布类目id
	        /// </summary>
	        [XmlElement("pcate_id")]
	        public long PcateId { get; set; }
	
	        /// <summary>
	        /// snad纠纷提起率得分
	        /// </summary>
	        [XmlElement("snad_issue_score")]
	        public string SnadIssueScore { get; set; }
	
	        /// <summary>
	        /// 总得分
	        /// </summary>
	        [XmlElement("total_score")]
	        public string TotalScore { get; set; }
}

	/// <summary>
/// AeServiceScoreDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeServiceScoreDtoDomain : TopObject
{
	        /// <summary>
	        /// 拍而不卖得分
	        /// </summary>
	        [XmlElement("buy_not_sel_score")]
	        public string BuyNotSelScore { get; set; }
	
	        /// <summary>
	        /// DSR卖家服务得分
	        /// </summary>
	        [XmlElement("dsr_communicate_score")]
	        public string DsrCommunicateScore { get; set; }
	
	        /// <summary>
	        /// DSR物流得分
	        /// </summary>
	        [XmlElement("dsr_logis_score")]
	        public string DsrLogisScore { get; set; }
	
	        /// <summary>
	        /// DSR商品描述得分
	        /// </summary>
	        [XmlElement("dsr_prod_score")]
	        public string DsrProdScore { get; set; }
	
	        /// <summary>
	        /// 未收到货纠纷得分
	        /// </summary>
	        [XmlElement("nr_issue_score")]
	        public string NrIssueScore { get; set; }
	
	        /// <summary>
	        /// 货不对版纠纷得分
	        /// </summary>
	        [XmlElement("snad_issue_score")]
	        public string SnadIssueScore { get; set; }
	
	        /// <summary>
	        /// 服务总得分
	        /// </summary>
	        [XmlElement("total_score")]
	        public string TotalScore { get; set; }
}

	/// <summary>
/// AeServiceScoreWeightDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeServiceScoreWeightDtoDomain : TopObject
{
	        /// <summary>
	        /// DSR卖家服务权重
	        /// </summary>
	        [XmlElement("dsr_communicat_weight")]
	        public long DsrCommunicatWeight { get; set; }
	
	        /// <summary>
	        /// DSR商品描述权重
	        /// </summary>
	        [XmlElement("dsr_good_description_weight")]
	        public long DsrGoodDescriptionWeight { get; set; }
	
	        /// <summary>
	        /// DSR物流权重
	        /// </summary>
	        [XmlElement("dsr_logistics_weight")]
	        public long DsrLogisticsWeight { get; set; }
	
	        /// <summary>
	        /// 拍而不卖率权重
	        /// </summary>
	        [XmlElement("not_sell_weight")]
	        public long NotSellWeight { get; set; }
	
	        /// <summary>
	        /// NR纠纷提起率权重
	        /// </summary>
	        [XmlElement("nr_issue_weight")]
	        public long NrIssueWeight { get; set; }
	
	        /// <summary>
	        /// SNAD纠纷提起率权重
	        /// </summary>
	        [XmlElement("snad_issue_weight")]
	        public long SnadIssueWeight { get; set; }
}

	/// <summary>
/// AeServiceScoreInfoDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeServiceScoreInfoDtoDomain : TopObject
{
	        /// <summary>
	        /// 考核父订单数
	        /// </summary>
	        [XmlElement("check_mord_cnt")]
	        public long CheckMordCnt { get; set; }
	
	        /// <summary>
	        /// 考核父订单数（1个月考核期）
	        /// </summary>
	        [XmlElement("check_mord_cnt1m")]
	        public long CheckMordCnt1m { get; set; }
	
	        /// <summary>
	        /// 考核父订单数（3个月考核期）
	        /// </summary>
	        [XmlElement("check_mord_cnt3m")]
	        public long CheckMordCnt3m { get; set; }
	
	        /// <summary>
	        /// 服务指标信息
	        /// </summary>
	        [XmlElement("index_d_t_o")]
	        public AeServiceIndexDtoDomain IndexDTO { get; set; }
	
	        /// <summary>
	        /// 行业平均指标
	        /// </summary>
	        [XmlElement("industry_avg_index_d_t_o")]
	        public AeIndustryAvgServiceIndexDtoDomain IndustryAvgIndexDTO { get; set; }
	
	        /// <summary>
	        /// 行业平均得分
	        /// </summary>
	        [XmlElement("industry_avg_score_d_t_o")]
	        public AeIndustryAvgServiceScoreDtoDomain IndustryAvgScoreDTO { get; set; }
	
	        /// <summary>
	        /// 服务得分信息
	        /// </summary>
	        [XmlElement("score_d_t_o")]
	        public AeServiceScoreDtoDomain ScoreDTO { get; set; }
	
	        /// <summary>
	        /// 服务分计算截止时间
	        /// </summary>
	        [XmlElement("stat_end_date")]
	        public string StatEndDate { get; set; }
	
	        /// <summary>
	        /// 服务分计算起始时间
	        /// </summary>
	        [XmlElement("stat_start_date")]
	        public string StatStartDate { get; set; }
	
	        /// <summary>
	        /// 考核项权重信息
	        /// </summary>
	        [XmlElement("weight_d_t_o")]
	        public AeServiceScoreWeightDtoDomain WeightDTO { get; set; }
}

	/// <summary>
/// AeStoreServiceScoreInfoDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeStoreServiceScoreInfoDtoDomain : TopObject
{
	        /// <summary>
	        /// 主赚二级类目id
	        /// </summary>
	        [XmlElement("prim_opr_pcate_lv2_id")]
	        public long PrimOprPcateLv2Id { get; set; }
	
	        /// <summary>
	        /// 主赚二级类目名称
	        /// </summary>
	        [XmlElement("prim_opr_pcate_lv2_name")]
	        public string PrimOprPcateLv2Name { get; set; }
	
	        /// <summary>
	        /// 服务分具体信息
	        /// </summary>
	        [XmlElement("service_score_info_d_t_o")]
	        public AeServiceScoreInfoDtoDomain ServiceScoreInfoDTO { get; set; }
}

	/// <summary>
/// AeStoreServiceScoreInfoResponseDomain Data Structure.
/// </summary>
[Serializable]

public class AeStoreServiceScoreInfoResponseDomain : TopObject
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
	        /// 请求是否成功
	        /// </summary>
	        [XmlElement("is_success")]
	        public bool IsSuccess { get; set; }
	
	        /// <summary>
	        /// 返回结果
	        /// </summary>
	        [XmlElement("result")]
	        public AeStoreServiceScoreInfoDtoDomain Result { get; set; }
}

    }
}
