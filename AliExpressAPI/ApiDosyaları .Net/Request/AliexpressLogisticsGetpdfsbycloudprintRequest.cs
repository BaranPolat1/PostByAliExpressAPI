using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.logistics.getpdfsbycloudprint
    /// </summary>
    public class AliexpressLogisticsGetpdfsbycloudprintRequest : BaseTopRequest<Top.Api.Response.AliexpressLogisticsGetpdfsbycloudprintResponse>
    {
        /// <summary>
        /// 是否打印详情
        /// </summary>
        public Nullable<bool> PrintDetail { get; set; }

        /// <summary>
        /// 批量查询线上发货信息进去打印,列表类型，以json格式来表达
        /// </summary>
        public string WarehouseOrderQueryDTOs { get; set; }

        public List<AeopWarehouseOrderQueryPdfRequestDomain> WarehouseOrderQueryDTOs_ { set { this.WarehouseOrderQueryDTOs = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.logistics.getpdfsbycloudprint";
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
            RequestValidator.ValidateObjectMaxListSize("warehouse_order_query_d_t_os", this.WarehouseOrderQueryDTOs, 100);
        }

	/// <summary>
/// AeopWarehouseOrderQueryPdfRequestDomain Data Structure.
/// </summary>
[Serializable]

public class AeopWarehouseOrderQueryPdfRequestDomain : TopObject
{
	        /// <summary>
	        /// 自定义分拣单信息
	        /// </summary>
	        [XmlElement("extend_data")]
	        public string ExtendData { get; set; }
	
	        /// <summary>
	        /// 物流订单号
	        /// </summary>
	        [XmlElement("id")]
	        public Nullable<long> Id { get; set; }
	
	        /// <summary>
	        /// 创建线上发货  产生的 国际运单号
	        /// </summary>
	        [XmlElement("international_logistics_id")]
	        public string InternationalLogisticsId { get; set; }
}

        #endregion
    }
}
