using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.offer.redefining.createbundle
    /// </summary>
    public class AliexpressOfferRedefiningCreatebundleRequest : BaseTopRequest<Top.Api.Response.AliexpressOfferRedefiningCreatebundleResponse>
    {
        /// <summary>
        /// 商品搭配
        /// </summary>
        public string AeopOfferBundle { get; set; }

        public AeopOfferBundleDomain AeopOfferBundle_ { set { this.AeopOfferBundle = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.offer.redefining.createbundle";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("aeop_offer_bundle", this.AeopOfferBundle);
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
/// AeopBundleItemSkuDomain Data Structure.
/// </summary>
[Serializable]

public class AeopBundleItemSkuDomain : TopObject
{
	        /// <summary>
	        /// 搭配价格
	        /// </summary>
	        [XmlElement("bundle_price")]
	        public string BundlePrice { get; set; }
	
	        /// <summary>
	        /// 币别
	        /// </summary>
	        [XmlElement("currency")]
	        public string Currency { get; set; }
	
	        /// <summary>
	        /// SKU原价格
	        /// </summary>
	        [XmlElement("original_price")]
	        public string OriginalPrice { get; set; }
	
	        /// <summary>
	        /// SKU唯一标识
	        /// </summary>
	        [XmlElement("sku_id")]
	        public Nullable<long> SkuId { get; set; }
}

	/// <summary>
/// AeopBundleItemDomain Data Structure.
/// </summary>
[Serializable]

public class AeopBundleItemDomain : TopObject
{
	        /// <summary>
	        /// 主商品ID
	        /// </summary>
	        [XmlElement("item_id")]
	        public Nullable<long> ItemId { get; set; }
	
	        /// <summary>
	        /// 主商品SKU列表
	        /// </summary>
	        [XmlArray("sku_list")]
	        [XmlArrayItem("aeop_bundle_item_sku")]
	        public List<AeopBundleItemSkuDomain> SkuList { get; set; }
}

	/// <summary>
/// AeopBundleSubItemDomain Data Structure.
/// </summary>
[Serializable]

public class AeopBundleSubItemDomain : TopObject
{
	        /// <summary>
	        /// 搭配商品ID
	        /// </summary>
	        [XmlElement("item_id")]
	        public Nullable<long> ItemId { get; set; }
	
	        /// <summary>
	        /// 搭配商品排列顺序
	        /// </summary>
	        [XmlElement("order")]
	        public Nullable<long> Order { get; set; }
	
	        /// <summary>
	        /// 搭配商品SKU
	        /// </summary>
	        [XmlArray("sku_list")]
	        [XmlArrayItem("aeop_bundle_item_sku")]
	        public List<AeopBundleItemSkuDomain> SkuList { get; set; }
}

	/// <summary>
/// AeopOfferBundleDomain Data Structure.
/// </summary>
[Serializable]

public class AeopOfferBundleDomain : TopObject
{
	        /// <summary>
	        /// 搭配主商品
	        /// </summary>
	        [XmlElement("main_item")]
	        public AeopBundleItemDomain MainItem { get; set; }
	
	        /// <summary>
	        /// 搭配商品列表
	        /// </summary>
	        [XmlArray("sub_item_list")]
	        [XmlArrayItem("aeop_bundle_sub_item")]
	        public List<AeopBundleSubItemDomain> SubItemList { get; set; }
}

        #endregion
    }
}
