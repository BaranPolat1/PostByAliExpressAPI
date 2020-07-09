using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressMerchantRedefiningQuerydsrddisputeproductlistResponse.
    /// </summary>
    public class AliexpressMerchantRedefiningQuerydsrddisputeproductlistResponse : TopResponse
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlElement("result")]
        public AeDisputeProductListQueryResponseDomain Result { get; set; }

	/// <summary>
/// AeDisputeProductDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeDisputeProductDtoDomain : TopObject
{
	        /// <summary>
	        /// 是否已下架
	        /// </summary>
	        [XmlElement("is_offline")]
	        public string IsOffline { get; set; }
	
	        /// <summary>
	        /// 商品ID
	        /// </summary>
	        [XmlElement("product_id")]
	        public long ProductId { get; set; }
	
	        /// <summary>
	        /// 商品名称
	        /// </summary>
	        [XmlElement("product_name")]
	        public string ProductName { get; set; }
	
	        /// <summary>
	        /// 得分
	        /// </summary>
	        [XmlElement("score")]
	        public string Score { get; set; }
}

	/// <summary>
/// AeDisputeProductListQueryResponseDomain Data Structure.
/// </summary>
[Serializable]

public class AeDisputeProductListQueryResponseDomain : TopObject
{
	        /// <summary>
	        /// 错误代码
	        /// </summary>
	        [XmlElement("error_code")]
	        public string ErrorCode { get; set; }
	
	        /// <summary>
	        /// 错误消息
	        /// </summary>
	        [XmlElement("error_msg")]
	        public string ErrorMsg { get; set; }
	
	        /// <summary>
	        /// 请求是否成功
	        /// </summary>
	        [XmlElement("is_success")]
	        public bool IsSuccess { get; set; }
	
	        /// <summary>
	        /// list
	        /// </summary>
	        [XmlArray("list")]
	        [XmlArrayItem("ae_dispute_product_dto")]
	        public List<AeDisputeProductDtoDomain> List { get; set; }
	
	        /// <summary>
	        /// 总记录条数
	        /// </summary>
	        [XmlElement("total_size")]
	        public long TotalSize { get; set; }
}

    }
}
