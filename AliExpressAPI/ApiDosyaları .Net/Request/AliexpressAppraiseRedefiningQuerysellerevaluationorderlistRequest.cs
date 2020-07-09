using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.appraise.redefining.querysellerevaluationorderlist
    /// </summary>
    public class AliexpressAppraiseRedefiningQuerysellerevaluationorderlistRequest : BaseTopRequest<Top.Api.Response.AliexpressAppraiseRedefiningQuerysellerevaluationorderlistResponse>
    {
        /// <summary>
        /// 查询参数
        /// </summary>
        public string QueryDTO { get; set; }

        public SellerEvaluationOpenQueryDtoDomain QueryDTO_ { set { this.QueryDTO = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.appraise.redefining.querysellerevaluationorderlist";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("query_d_t_o", this.QueryDTO);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("query_d_t_o", this.QueryDTO);
        }

	/// <summary>
/// SellerEvaluationOpenQueryDtoDomain Data Structure.
/// </summary>
[Serializable]

public class SellerEvaluationOpenQueryDtoDomain : TopObject
{
	        /// <summary>
	        /// 无效参数，子订单号，多个用英文逗号分隔
	        /// </summary>
	        [XmlElement("child_order_ids")]
	        public string ChildOrderIds { get; set; }
	
	        /// <summary>
	        /// 当前页
	        /// </summary>
	        [XmlElement("current_page")]
	        public Nullable<long> CurrentPage { get; set; }
	
	        /// <summary>
	        /// 无效参数，订单结束时间，查询起始值，格式:MM/dd/yyyy
	        /// </summary>
	        [XmlElement("order_finish_time_end")]
	        public string OrderFinishTimeEnd { get; set; }
	
	        /// <summary>
	        /// 无效参数，订单结束时间，查询截止值，格式:MM/dd/yyyy
	        /// </summary>
	        [XmlElement("order_finish_time_start")]
	        public string OrderFinishTimeStart { get; set; }
	
	        /// <summary>
	        /// 父订单号，多个用英文逗号分隔
	        /// </summary>
	        [XmlElement("order_ids")]
	        public string OrderIds { get; set; }
	
	        /// <summary>
	        /// 每页获取记录数
	        /// </summary>
	        [XmlElement("page_size")]
	        public Nullable<long> PageSize { get; set; }
	
	        /// <summary>
	        /// 无效参数，卖家留评状态：yes：已留评；no：未留评；all：所有状态；默认未留评
	        /// </summary>
	        [XmlElement("seller_feedback_status")]
	        public string SellerFeedbackStatus { get; set; }
}

        #endregion
    }
}
