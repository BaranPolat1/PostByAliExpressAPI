using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.issue.solution.save
    /// </summary>
    public class AliexpressIssueSolutionSaveRequest : BaseTopRequest<Top.Api.Response.AliexpressIssueSolutionSaveResponse>
    {
        /// <summary>
        /// 详细参数如下
        /// </summary>
        public string ParamDto { get; set; }

        public SellerAddOrModifySolutionDtoDomain ParamDto_ { set { this.ParamDto = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.issue.solution.save";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("param_dto", this.ParamDto);
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
/// SellerAddOrModifySolutionDtoDomain Data Structure.
/// </summary>
[Serializable]

public class SellerAddOrModifySolutionDtoDomain : TopObject
{
	        /// <summary>
	        /// 是否新增方案(true新增,false修改)
	        /// </summary>
	        [XmlElement("add_seller_solution")]
	        public Nullable<bool> AddSellerSolution { get; set; }
	
	        /// <summary>
	        /// 方案类型(SNAD才可更改类型)：退款refund,退货退款return_and_refund
	        /// </summary>
	        [XmlElement("add_solution_type")]
	        public string AddSolutionType { get; set; }
	
	        /// <summary>
	        /// 买家登录id
	        /// </summary>
	        [XmlElement("buyer_login_id")]
	        public string BuyerLoginId { get; set; }
	
	        /// <summary>
	        /// 拒绝买家方案id，增加方案时必填
	        /// </summary>
	        [XmlElement("buyer_solution_id")]
	        public Nullable<long> BuyerSolutionId { get; set; }
	
	        /// <summary>
	        /// 纠纷id
	        /// </summary>
	        [XmlElement("issue_id")]
	        public Nullable<long> IssueId { get; set; }
	
	        /// <summary>
	        /// 修改的卖家方案id，修改方案时必填
	        /// </summary>
	        [XmlElement("modify_seller_solution_id")]
	        public Nullable<long> ModifySellerSolutionId { get; set; }
	
	        /// <summary>
	        /// 新增or修改金额(元)
	        /// </summary>
	        [XmlElement("refund_amount")]
	        public string RefundAmount { get; set; }
	
	        /// <summary>
	        /// 新增or修改金额的币种
	        /// </summary>
	        [XmlElement("refund_amount_currency")]
	        public string RefundAmountCurrency { get; set; }
	
	        /// <summary>
	        /// 退货地址id，新增退货方案时必填
	        /// </summary>
	        [XmlElement("return_good_address_id")]
	        public Nullable<long> ReturnGoodAddressId { get; set; }
	
	        /// <summary>
	        /// 新增or修改理由说明
	        /// </summary>
	        [XmlElement("solution_context")]
	        public string SolutionContext { get; set; }
}

        #endregion
    }
}
