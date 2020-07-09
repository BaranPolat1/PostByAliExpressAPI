using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressDataRedefiningQueryproductbusinessinfobyidResponse.
    /// </summary>
    public class AliexpressDataRedefiningQueryproductbusinessinfobyidResponse : TopResponse
    {
        /// <summary>
        /// 单个商品浏览量。 {"addCartCount":加入购物车,"exposedCount":曝光量,"favoritedCount":加心愿单量,"gmvPerBuyer":客单价,"gmvPerBuyer30d":最近30天客单价,"gmvPerOrder":订单均额,"gmvPerOrder30d":最近30天订单均额,"outputOrder":成交订单数,"refundAmt":退款金额,"success":本次调用是否成功,"viewedCount":30天浏览量}  没有结果时的返回： {\"itemList\":商品列表为空,\"success\":本次调用是否成功,\"totalItem\":商品数为0}
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

    }
}
