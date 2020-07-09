using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.trade.redefining.findorderreceiptinfo
    /// </summary>
    public class AliexpressTradeRedefiningFindorderreceiptinfoRequest : BaseTopRequest<Top.Api.Response.AliexpressTradeRedefiningFindorderreceiptinfoResponse>
    {
        /// <summary>
        /// 查询条件
        /// </summary>
        public string Param1 { get; set; }

        public TpOpenSingleOrderQueryDomain Param1_ { set { this.Param1 = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.trade.redefining.findorderreceiptinfo";
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
/// TpOpenSingleOrderQueryDomain Data Structure.
/// </summary>
[Serializable]

public class TpOpenSingleOrderQueryDomain : TopObject
{
	        /// <summary>
	        /// 无效，请不要设置任何值
	        /// </summary>
	        [XmlElement("buyer_aliid")]
	        public Nullable<long> BuyerAliid { get; set; }
	
	        /// <summary>
	        /// 无效，请不要设置任何值
	        /// </summary>
	        [XmlElement("ext_info_bit_flag")]
	        public Nullable<long> ExtInfoBitFlag { get; set; }
	
	        /// <summary>
	        /// 无效，请不要设置任何值
	        /// </summary>
	        [XmlElement("field_list")]
	        public string FieldList { get; set; }
	
	        /// <summary>
	        /// 订单ID
	        /// </summary>
	        [XmlElement("order_id")]
	        public Nullable<long> OrderId { get; set; }
	
	        /// <summary>
	        /// 无效，请不要设置任何值
	        /// </summary>
	        [XmlElement("seller_aliid")]
	        public Nullable<long> SellerAliid { get; set; }
	
	        /// <summary>
	        /// 无效，请不要设置任何值
	        /// </summary>
	        [XmlElement("seller_operator_aliid")]
	        public Nullable<long> SellerOperatorAliid { get; set; }
	
	        /// <summary>
	        /// 无效，请不要设置任何值
	        /// </summary>
	        [XmlElement("show_id")]
	        public string ShowId { get; set; }
}

        #endregion
    }
}
