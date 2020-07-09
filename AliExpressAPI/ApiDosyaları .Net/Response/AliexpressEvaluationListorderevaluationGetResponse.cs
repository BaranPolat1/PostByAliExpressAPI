using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressEvaluationListorderevaluationGetResponse.
    /// </summary>
    public class AliexpressEvaluationListorderevaluationGetResponse : TopResponse
    {
        /// <summary>
        /// 详细说明如下
        /// </summary>
        [XmlArray("target_list")]
        [XmlArrayItem("trade_evaluation_open_dto")]
        public List<TradeEvaluationOpenDtoDomain> TargetList { get; set; }

        /// <summary>
        /// timeStamp
        /// </summary>
        [XmlElement("time_stamp")]
        public string TimeStamp { get; set; }

	/// <summary>
/// TradeEvaluationOpenDtoDomain Data Structure.
/// </summary>
[Serializable]

public class TradeEvaluationOpenDtoDomain : TopObject
{
	        /// <summary>
	        /// 买家评价星级
	        /// </summary>
	        [XmlElement("buyer_evaluation")]
	        public string BuyerEvaluation { get; set; }
	
	        /// <summary>
	        /// 买家已评时间
	        /// </summary>
	        [XmlElement("buyer_fb_date")]
	        public string BuyerFbDate { get; set; }
	
	        /// <summary>
	        /// 买家评价内容
	        /// </summary>
	        [XmlElement("buyer_feedback")]
	        public string BuyerFeedback { get; set; }
	
	        /// <summary>
	        /// 买家登录帐号
	        /// </summary>
	        [XmlElement("buyer_login_id")]
	        public string BuyerLoginId { get; set; }
	
	        /// <summary>
	        /// 买家回复内容
	        /// </summary>
	        [XmlElement("buyer_reply")]
	        public string BuyerReply { get; set; }
	
	        /// <summary>
	        /// 创建时间
	        /// </summary>
	        [XmlElement("gmt_create")]
	        public string GmtCreate { get; set; }
	
	        /// <summary>
	        /// 最后修改时间
	        /// </summary>
	        [XmlElement("gmt_modified")]
	        public string GmtModified { get; set; }
	
	        /// <summary>
	        /// 订单完成时间
	        /// </summary>
	        [XmlElement("gmt_order_complete")]
	        public string GmtOrderComplete { get; set; }
	
	        /// <summary>
	        /// 子订单id
	        /// </summary>
	        [XmlElement("order_id")]
	        public long OrderId { get; set; }
	
	        /// <summary>
	        /// 父订单id
	        /// </summary>
	        [XmlElement("parent_order_id")]
	        public long ParentOrderId { get; set; }
	
	        /// <summary>
	        /// 商品id
	        /// </summary>
	        [XmlElement("product_id")]
	        public long ProductId { get; set; }
	
	        /// <summary>
	        /// 卖家评价星级
	        /// </summary>
	        [XmlElement("seller_evaluation")]
	        public string SellerEvaluation { get; set; }
	
	        /// <summary>
	        /// 卖家已评时间
	        /// </summary>
	        [XmlElement("seller_fb_date")]
	        public string SellerFbDate { get; set; }
	
	        /// <summary>
	        /// 卖家评价内容
	        /// </summary>
	        [XmlElement("seller_feedback")]
	        public string SellerFeedback { get; set; }
	
	        /// <summary>
	        /// 卖家登录帐号
	        /// </summary>
	        [XmlElement("seller_login_id")]
	        public string SellerLoginId { get; set; }
	
	        /// <summary>
	        /// 卖家回复内容
	        /// </summary>
	        [XmlElement("seller_reply")]
	        public string SellerReply { get; set; }
	
	        /// <summary>
	        /// 评价生效日期
	        /// </summary>
	        [XmlElement("valid_date")]
	        public string ValidDate { get; set; }
}

    }
}
