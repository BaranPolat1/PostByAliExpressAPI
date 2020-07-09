using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.solution.order.info.get
    /// </summary>
    public class AliexpressSolutionOrderInfoGetRequest : BaseTopRequest<Top.Api.Response.AliexpressSolutionOrderInfoGetResponse>
    {
        /// <summary>
        /// param
        /// </summary>
        public string Param1 { get; set; }

        public OrderDetailQueryDomain Param1_ { set { this.Param1 = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.solution.order.info.get";
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
/// OrderDetailQueryDomain Data Structure.
/// </summary>
[Serializable]

public class OrderDetailQueryDomain : TopObject
{
	        /// <summary>
	        /// It defines which details to be returned. Convert the number into binary format, for example, 16 to 10000. Only the last 5 bits take effects, starting from the end, 1st bit is for issue information, 2nd bit is for loan information, 3rd bit is for logistics information, 4th bit is for buyer information and 5th bit is for refund information. If any bit is 1, it means to return the corresponding information, for example, 3 wich is 00011, means to return issue information and logistics information. Leaving this field blank means return all information.
	        /// </summary>
	        [XmlElement("ext_info_bit_flag")]
	        public Nullable<long> ExtInfoBitFlag { get; set; }
	
	        /// <summary>
	        /// Order id
	        /// </summary>
	        [XmlElement("order_id")]
	        public Nullable<long> OrderId { get; set; }
}

        #endregion
    }
}
