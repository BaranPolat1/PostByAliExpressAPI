using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.trade.new.redefining.findorderbyid
    /// </summary>
    public class AliexpressTradeNewRedefiningFindorderbyidRequest : BaseTopRequest<Top.Api.Response.AliexpressTradeNewRedefiningFindorderbyidResponse>
    {
        /// <summary>
        /// 详细参考如下
        /// </summary>
        public string Param1 { get; set; }

        public AeopTpSingleOrderQueryDomain Param1_ { set { this.Param1 = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.trade.new.redefining.findorderbyid";
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
/// AeopTpSingleOrderQueryDomain Data Structure.
/// </summary>
[Serializable]

public class AeopTpSingleOrderQueryDomain : TopObject
{
	        /// <summary>
	        /// 扩展信息目前支持纠纷信息，放款信息，物流信息，买方信息和退款信息，分别对应二进制位1,2,3,4,5。例如，只查询纠纷信息和物流信息，extInfoBitFlag=10100；将此字段留空意味着返回所有信息。
	        /// </summary>
	        [XmlElement("ext_info_bit_flag")]
	        public Nullable<long> ExtInfoBitFlag { get; set; }
	
	        /// <summary>
	        /// 暂不支持.
	        /// </summary>
	        [XmlElement("field_list")]
	        public string FieldList { get; set; }
	
	        /// <summary>
	        /// 订单id
	        /// </summary>
	        [XmlElement("order_id")]
	        public Nullable<long> OrderId { get; set; }
	
	        /// <summary>
	        /// 暂不支持
	        /// </summary>
	        [XmlElement("show_id")]
	        public string ShowId { get; set; }
}

        #endregion
    }
}
