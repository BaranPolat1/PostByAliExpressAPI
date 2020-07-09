using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.logistics.redefining.getprintinfos
    /// </summary>
    public class AliexpressLogisticsRedefiningGetprintinfosRequest : BaseTopRequest<Top.Api.Response.AliexpressLogisticsRedefiningGetprintinfosResponse>
    {
        /// <summary>
        /// print detail
        /// </summary>
        public Nullable<bool> PrintDetail { get; set; }

        /// <summary>
        /// 12345
        /// </summary>
        public string WarehouseOrderQueryDTOs { get; set; }

        public List<AeopWarehouseOrderQueryPdfRequestDomain> WarehouseOrderQueryDTOs_ { set { this.WarehouseOrderQueryDTOs = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.logistics.redefining.getprintinfos";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("print_detail", this.PrintDetail);
            parameters.Add("warehouse_order_query_d_t_os", this.WarehouseOrderQueryDTOs);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("warehouse_order_query_d_t_os", this.WarehouseOrderQueryDTOs);
            RequestValidator.ValidateObjectMaxListSize("warehouse_order_query_d_t_os", this.WarehouseOrderQueryDTOs, 200);
        }

	/// <summary>
/// AeopWarehouseOrderQueryPdfRequestDomain Data Structure.
/// </summary>
[Serializable]

public class AeopWarehouseOrderQueryPdfRequestDomain : TopObject
{
	        /// <summary>
	        /// id is optional
	        /// </summary>
	        [XmlElement("id")]
	        public Nullable<long> Id { get; set; }
	
	        /// <summary>
	        /// international logistics waybill ID
	        /// </summary>
	        [XmlElement("international_logistics_id")]
	        public string InternationalLogisticsId { get; set; }
}

        #endregion
    }
}
