using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressMarketingStorepromotionProductsQueryResponse.
    /// </summary>
    public class AliexpressMarketingStorepromotionProductsQueryResponse : TopResponse
    {
        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 商品列表
        /// </summary>
        [XmlArray("product_list")]
        [XmlArrayItem("number")]
        public List<long> ProductList { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }

    }
}
