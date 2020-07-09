using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressOfferRedefiningInitialnewbundleResponse.
    /// </summary>
    public class AliexpressOfferRedefiningInitialnewbundleResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public AeopOfferBundleInitialResultDomain Result { get; set; }

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
	        /// sku标签
	        /// </summary>
	        [XmlElement("label")]
	        public string Label { get; set; }
	
	        /// <summary>
	        /// sku原价
	        /// </summary>
	        [XmlElement("original_price")]
	        public string OriginalPrice { get; set; }
	
	        /// <summary>
	        /// sku唯一标识
	        /// </summary>
	        [XmlElement("sku_id")]
	        public long SkuId { get; set; }
}

	/// <summary>
/// AeopBundleItemDomain Data Structure.
/// </summary>
[Serializable]

public class AeopBundleItemDomain : TopObject
{
	        /// <summary>
	        /// 主商品主图
	        /// </summary>
	        [XmlArray("image_list")]
	        [XmlArrayItem("string")]
	        public List<string> ImageList { get; set; }
	
	        /// <summary>
	        /// 主商品ID
	        /// </summary>
	        [XmlElement("item_id")]
	        public long ItemId { get; set; }
	
	        /// <summary>
	        /// sku列表
	        /// </summary>
	        [XmlArray("sku_list")]
	        [XmlArrayItem("aeop_bundle_item_sku")]
	        public List<AeopBundleItemSkuDomain> SkuList { get; set; }
	
	        /// <summary>
	        /// 主商品标题
	        /// </summary>
	        [XmlElement("subject")]
	        public string Subject { get; set; }
}

	/// <summary>
/// AeopBundleSubItemDomain Data Structure.
/// </summary>
[Serializable]

public class AeopBundleSubItemDomain : TopObject
{
	        /// <summary>
	        /// 搭配商品主图
	        /// </summary>
	        [XmlArray("image_list")]
	        [XmlArrayItem("string")]
	        public List<string> ImageList { get; set; }
	
	        /// <summary>
	        /// 搭配商品ID
	        /// </summary>
	        [XmlElement("item_id")]
	        public long ItemId { get; set; }
	
	        /// <summary>
	        /// 搭配商品排列顺序
	        /// </summary>
	        [XmlElement("order")]
	        public long Order { get; set; }
	
	        /// <summary>
	        /// sku列表
	        /// </summary>
	        [XmlArray("sku_list")]
	        [XmlArrayItem("aeop_bundle_item_sku")]
	        public List<AeopBundleItemSkuDomain> SkuList { get; set; }
	
	        /// <summary>
	        /// 搭配商品标题
	        /// </summary>
	        [XmlElement("subject")]
	        public string Subject { get; set; }
}

	/// <summary>
/// AeopOfferBundleInitialResultDomain Data Structure.
/// </summary>
[Serializable]

public class AeopOfferBundleInitialResultDomain : TopObject
{
	        /// <summary>
	        /// 错误码
	        /// </summary>
	        [XmlElement("error_code")]
	        public long ErrorCode { get; set; }
	
	        /// <summary>
	        /// 错误消息
	        /// </summary>
	        [XmlElement("error_message")]
	        public string ErrorMessage { get; set; }
	
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
	
	        /// <summary>
	        /// 返回时间
	        /// </summary>
	        [XmlElement("time_stamp")]
	        public string TimeStamp { get; set; }
}

    }
}
