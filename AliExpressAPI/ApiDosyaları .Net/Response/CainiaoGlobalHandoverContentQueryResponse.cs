using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// CainiaoGlobalHandoverContentQueryResponse.
    /// </summary>
    public class CainiaoGlobalHandoverContentQueryResponse : TopResponse
    {
        /// <summary>
        /// 请求响应
        /// </summary>
        [XmlElement("result")]
        public HsfResultDomain Result { get; set; }

	/// <summary>
/// OpenParcelOrderDtoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenParcelOrderDtoDomain : TopObject
{
	        /// <summary>
	        /// 小包异常码
	        /// </summary>
	        [XmlElement("exception_code")]
	        public string ExceptionCode { get; set; }
	
	        /// <summary>
	        /// 小包物流订单编码
	        /// </summary>
	        [XmlElement("order_code")]
	        public string OrderCode { get; set; }
	
	        /// <summary>
	        /// 小包状态code
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
	
	        /// <summary>
	        /// 小包状态名称
	        /// </summary>
	        [XmlElement("status_name")]
	        public string StatusName { get; set; }
}

	/// <summary>
/// OpenHandoverContentDetailResponseDomain Data Structure.
/// </summary>
[Serializable]

public class OpenHandoverContentDetailResponseDomain : TopObject
{
	        /// <summary>
	        /// 实际费用
	        /// </summary>
	        [XmlElement("actual_fee")]
	        public string ActualFee { get; set; }
	
	        /// <summary>
	        /// 实际重量
	        /// </summary>
	        [XmlElement("actual_weight")]
	        public string ActualWeight { get; set; }
	
	        /// <summary>
	        /// 预估费用
	        /// </summary>
	        [XmlElement("estimate_fee")]
	        public string EstimateFee { get; set; }
	
	        /// <summary>
	        /// 预估重量
	        /// </summary>
	        [XmlElement("estimate_weight")]
	        public string EstimateWeight { get; set; }
	
	        /// <summary>
	        /// 费用币种
	        /// </summary>
	        [XmlElement("fee_currency")]
	        public string FeeCurrency { get; set; }
	
	        /// <summary>
	        /// 费用单位
	        /// </summary>
	        [XmlElement("fee_unit")]
	        public string FeeUnit { get; set; }
	
	        /// <summary>
	        /// 交接物关联的交接单状态code
	        /// </summary>
	        [XmlElement("handover_order_status")]
	        public string HandoverOrderStatus { get; set; }
	
	        /// <summary>
	        /// 交接物关联的交接单状态名称
	        /// </summary>
	        [XmlElement("handover_order_status_name")]
	        public string HandoverOrderStatusName { get; set; }
	
	        /// <summary>
	        /// 交接物物流订单编号
	        /// </summary>
	        [XmlElement("order_code")]
	        public string OrderCode { get; set; }
	
	        /// <summary>
	        /// 大包关联的小包列表
	        /// </summary>
	        [XmlArray("parcel_order_list")]
	        [XmlArrayItem("open_parcel_order_dto")]
	        public List<OpenParcelOrderDtoDomain> ParcelOrderList { get; set; }
	
	        /// <summary>
	        /// 交接物状态
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
	
	        /// <summary>
	        /// 交接物状态
	        /// </summary>
	        [XmlElement("status_name")]
	        public string StatusName { get; set; }
	
	        /// <summary>
	        /// 交接物运单号
	        /// </summary>
	        [XmlElement("tracking_number")]
	        public string TrackingNumber { get; set; }
	
	        /// <summary>
	        /// 重量单位
	        /// </summary>
	        [XmlElement("weight_unit")]
	        public string WeightUnit { get; set; }
}

	/// <summary>
/// HsfResultDomain Data Structure.
/// </summary>
[Serializable]

public class HsfResultDomain : TopObject
{
	        /// <summary>
	        /// 大包详情
	        /// </summary>
	        [XmlElement("data")]
	        public OpenHandoverContentDetailResponseDomain Data { get; set; }
	
	        /// <summary>
	        /// 错误码
	        /// </summary>
	        [XmlElement("error_code")]
	        public string ErrorCode { get; set; }
	
	        /// <summary>
	        /// 错误描述
	        /// </summary>
	        [XmlElement("error_msg")]
	        public string ErrorMsg { get; set; }
	
	        /// <summary>
	        /// 请求结果
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
