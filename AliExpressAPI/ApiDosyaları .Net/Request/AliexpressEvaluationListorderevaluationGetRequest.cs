using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.evaluation.listorderevaluation.get
    /// </summary>
    public class AliexpressEvaluationListorderevaluationGetRequest : BaseTopRequest<Top.Api.Response.AliexpressEvaluationListorderevaluationGetResponse>
    {
        /// <summary>
        /// 详细参考如下
        /// </summary>
        public string TradeEvaluationRequest { get; set; }

        public TradeEvaluationRequestDomain TradeEvaluationRequest_ { set { this.TradeEvaluationRequest = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.evaluation.listorderevaluation.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("trade_evaluation_request", this.TradeEvaluationRequest);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
        }

	/// <summary>
/// TradeEvaluationRequestDomain Data Structure.
/// </summary>
[Serializable]

public class TradeEvaluationRequestDomain : TopObject
{
	        /// <summary>
	        /// 买家评价星级（1-5星）
	        /// </summary>
	        [XmlArray("buyer_product_ratings")]
	        [XmlArrayItem("number")]
	        public List<string> BuyerProductRatings { get; set; }
	
	        /// <summary>
	        /// 订单完成结束时间
	        /// </summary>
	        [XmlElement("end_order_complete_date")]
	        public string EndOrderCompleteDate { get; set; }
	
	        /// <summary>
	        /// 评价生效结束时间
	        /// </summary>
	        [XmlElement("end_valid_date")]
	        public string EndValidDate { get; set; }
	
	        /// <summary>
	        /// 父订单ID集合，最多50
	        /// </summary>
	        [XmlArray("parent_order_ids")]
	        [XmlArrayItem("number")]
	        public List<string> ParentOrderIds { get; set; }
	
	        /// <summary>
	        /// 商品id
	        /// </summary>
	        [XmlElement("product_id")]
	        public Nullable<long> ProductId { get; set; }
	
	        /// <summary>
	        /// 订单完成开始时间
	        /// </summary>
	        [XmlElement("start_order_complete_date")]
	        public string StartOrderCompleteDate { get; set; }
	
	        /// <summary>
	        /// 评价生效开始时间
	        /// </summary>
	        [XmlElement("start_valid_date")]
	        public string StartValidDate { get; set; }
}

        #endregion
    }
}
