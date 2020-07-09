using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.solution.order.receiptinfo.get
    /// </summary>
    public class AliexpressSolutionOrderReceiptinfoGetRequest : BaseTopRequest<Top.Api.Response.AliexpressSolutionOrderReceiptinfoGetResponse>
    {
        /// <summary>
        /// query param
        /// </summary>
        public string Param1 { get; set; }

        public SingleOrderQueryDomain Param1_ { set { this.Param1 = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.solution.order.receiptinfo.get";
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
/// SingleOrderQueryDomain Data Structure.
/// </summary>
[Serializable]

public class SingleOrderQueryDomain : TopObject
{
	        /// <summary>
	        /// order ID
	        /// </summary>
	        [XmlElement("order_id")]
	        public Nullable<long> OrderId { get; set; }
}

        #endregion
    }
}
