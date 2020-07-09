using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.logistics.redefining.getonlinelogisticsservicelistbyorderid
    /// </summary>
    public class AliexpressLogisticsRedefiningGetonlinelogisticsservicelistbyorderidRequest : BaseTopRequest<Top.Api.Response.AliexpressLogisticsRedefiningGetonlinelogisticsservicelistbyorderidResponse>
    {
        /// <summary>
        /// 包裹高度
        /// </summary>
        public Nullable<long> GoodsHeight { get; set; }

        /// <summary>
        /// 包裹长度
        /// </summary>
        public Nullable<long> GoodsLength { get; set; }

        /// <summary>
        /// 包裹重量
        /// </summary>
        public string GoodsWeight { get; set; }

        /// <summary>
        /// 包裹宽度
        /// </summary>
        public Nullable<long> GoodsWidth { get; set; }

        /// <summary>
        /// 多语言，zh_CN：中文、en_US：英语、ru_RU：俄语
        /// </summary>
        public string Locale { get; set; }

        /// <summary>
        /// 交易订单号
        /// </summary>
        public Nullable<long> OrderId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.logistics.redefining.getonlinelogisticsservicelistbyorderid";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("goods_height", this.GoodsHeight);
            parameters.Add("goods_length", this.GoodsLength);
            parameters.Add("goods_weight", this.GoodsWeight);
            parameters.Add("goods_width", this.GoodsWidth);
            parameters.Add("locale", this.Locale);
            parameters.Add("order_id", this.OrderId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("order_id", this.OrderId);
        }

        #endregion
    }
}
