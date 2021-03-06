using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.marketing.limiteddiscountpromotion.addpromotionproduct
    /// </summary>
    public class AliexpressMarketingLimiteddiscountpromotionAddpromotionproductRequest : BaseTopRequest<Top.Api.Response.AliexpressMarketingLimiteddiscountpromotionAddpromotionproductResponse>
    {
        /// <summary>
        /// 详细参考如下
        /// </summary>
        public string LimitedDiscProductInputDto { get; set; }

        public AeopLimitedDiscProductInputDtoDomain LimitedDiscProductInputDto_ { set { this.LimitedDiscProductInputDto = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.marketing.limiteddiscountpromotion.addpromotionproduct";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("limited_disc_product_input_dto", this.LimitedDiscProductInputDto);
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
/// AeopProductDiscountInfoDomain Data Structure.
/// </summary>
[Serializable]

public class AeopProductDiscountInfoDomain : TopObject
{
	        /// <summary>
	        /// 折扣
	        /// </summary>
	        [XmlElement("discount")]
	        public Nullable<long> Discount { get; set; }
	
	        /// <summary>
	        /// 终端 MOBILE or ALL
	        /// </summary>
	        [XmlElement("terminal")]
	        public string Terminal { get; set; }
}

	/// <summary>
/// AeopSkuInventoryInfoDomain Data Structure.
/// </summary>
[Serializable]

public class AeopSkuInventoryInfoDomain : TopObject
{
	        /// <summary>
	        /// 限时限量更改为共享库存，当前该字段仅当部分sku不参加活动时设置为0
	        /// </summary>
	        [XmlElement("quantity")]
	        public Nullable<long> Quantity { get; set; }
	
	        /// <summary>
	        /// sku属性
	        /// </summary>
	        [XmlElement("sku_attr")]
	        public string SkuAttr { get; set; }
}

	/// <summary>
/// AeopStorePromProductDomain Data Structure.
/// </summary>
[Serializable]

public class AeopStorePromProductDomain : TopObject
{
	        /// <summary>
	        /// 每人限购数量(每人最多购买数量)
	        /// </summary>
	        [XmlElement("buy_max_num")]
	        public Nullable<long> BuyMaxNum { get; set; }
	
	        /// <summary>
	        /// 活动商品优惠信息
	        /// </summary>
	        [XmlArray("product_discount_list")]
	        [XmlArrayItem("aeop_product_discount_info")]
	        public List<AeopProductDiscountInfoDomain> ProductDiscountList { get; set; }
	
	        /// <summary>
	        /// 商品id
	        /// </summary>
	        [XmlElement("product_id")]
	        public Nullable<long> ProductId { get; set; }
	
	        /// <summary>
	        /// 商品sku信息
	        /// </summary>
	        [XmlArray("sku_inventory_list")]
	        [XmlArrayItem("aeop_sku_inventory_info")]
	        public List<AeopSkuInventoryInfoDomain> SkuInventoryList { get; set; }
	
	        /// <summary>
	        /// 废弃：全局都是共享库存，废弃该字段，即使设置也不生效
	        /// </summary>
	        [XmlElement("used_warehouse")]
	        public Nullable<bool> UsedWarehouse { get; set; }
}

	/// <summary>
/// AeopLimitedDiscProductInputDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeopLimitedDiscProductInputDtoDomain : TopObject
{
	        /// <summary>
	        /// 已存在的粉丝折扣 默认为0
	        /// </summary>
	        [XmlElement("exist_store_fans_discount")]
	        public string ExistStoreFansDiscount { get; set; }
	
	        /// <summary>
	        /// 活动商品对象列表
	        /// </summary>
	        [XmlArray("product_objects")]
	        [XmlArrayItem("aeop_store_prom_product")]
	        public List<AeopStorePromProductDomain> ProductObjects { get; set; }
	
	        /// <summary>
	        /// 活动id
	        /// </summary>
	        [XmlElement("promotion_id")]
	        public Nullable<long> PromotionId { get; set; }
	
	        /// <summary>
	        /// 粉丝折扣,与exist_store_fans_discount不同值时，才会更新粉丝折扣
	        /// </summary>
	        [XmlElement("store_club_discount_rate")]
	        public string StoreClubDiscountRate { get; set; }
}

        #endregion
    }
}
