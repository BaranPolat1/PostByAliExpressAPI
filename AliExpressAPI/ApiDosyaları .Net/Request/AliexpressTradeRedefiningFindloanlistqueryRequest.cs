using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.trade.redefining.findloanlistquery
    /// </summary>
    public class AliexpressTradeRedefiningFindloanlistqueryRequest : BaseTopRequest<Top.Api.Response.AliexpressTradeRedefiningFindloanlistqueryResponse>
    {
        /// <summary>
        /// 入参
        /// </summary>
        public string Param1 { get; set; }

        public FundloanRequestDomain Param1_ { set { this.Param1 = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.trade.redefining.findloanlistquery";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("param1", this.Param1);
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
/// FundloanRequestDomain Data Structure.
/// </summary>
[Serializable]

public class FundloanRequestDomain : TopObject
{
	        /// <summary>
	        /// 放款时间截止值，格式: mm/dd/yyyy hh:mm:ss,如10/09/2013 00:00:00。时间需精确到秒，否则条件无效。
	        /// </summary>
	        [XmlElement("create_date_end")]
	        public string CreateDateEnd { get; set; }
	
	        /// <summary>
	        /// 放款时间起始值，格式: mm/dd/yyyy hh:mm:ss,如10/08/2013 00:00:00。时间需精确到秒，否则条件无效。
	        /// </summary>
	        [XmlElement("create_date_start")]
	        public string CreateDateStart { get; set; }
	
	        /// <summary>
	        /// 订单放款状态：wait_loan 未放款，loan_ok已放款。
	        /// </summary>
	        [XmlElement("loan_status")]
	        public string LoanStatus { get; set; }
	
	        /// <summary>
	        /// 主订单id，一次只能查询一个.
	        /// </summary>
	        [XmlElement("order_id")]
	        public Nullable<long> OrderId { get; set; }
	
	        /// <summary>
	        /// 当前页码.。
	        /// </summary>
	        [XmlElement("page")]
	        public Nullable<long> Page { get; set; }
	
	        /// <summary>
	        /// 每页个数，最大200。
	        /// </summary>
	        [XmlElement("page_size")]
	        public Nullable<long> PageSize { get; set; }
}

        #endregion
    }
}
