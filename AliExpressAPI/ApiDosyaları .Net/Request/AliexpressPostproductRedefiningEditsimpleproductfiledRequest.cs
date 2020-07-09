using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.postproduct.redefining.editsimpleproductfiled
    /// </summary>
    public class AliexpressPostproductRedefiningEditsimpleproductfiledRequest : BaseTopRequest<Top.Api.Response.AliexpressPostproductRedefiningEditsimpleproductfiledResponse>
    {
        /// <summary>
        /// 编辑的字段名称，为以下字段内容里的其中一项, 可以编辑的字段包括: subject: 商品的标题; detail: 商品的详细描述信息； deliveryTime: 备货期； groupId: 产品组； freightTemplateId: 运费模版； packageLength: 商品包装长度； packageWidth: 商品包装宽度； packageHeight：商品包装高度； grossWeight: 商品毛重； wsValidNum商品的有效天数；mobileDetail：无线详描（注意：该字段的提交修改，数据生效时间：商品（到期或手动）下架再上架生效。”）; reduceStrategy: 库存扣减策略(总共有2种：下单减库存(place_order_withhold)和支付减库存(payment_success_deduct)。);imageURLs:商品主图 多个图片时，用冒号分隔 ;promiseTemplateId:服务模板id
        /// </summary>
        public string FiedName { get; set; }

        /// <summary>
        /// 根据fiedName变化：fiedName=detail时，本字段是一段html字符串；fiedName=mobileDetail时，本字段的值是一段json字符串；fiedName=groupId时，本字段是一个产品分组唯一标识（数字类型）。
        /// </summary>
        public string Fiedvalue { get; set; }

        /// <summary>
        /// 指定编辑产品的id
        /// </summary>
        public Nullable<long> ProductId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.postproduct.redefining.editsimpleproductfiled";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("fied_name", this.FiedName);
            parameters.Add("fiedvalue", this.Fiedvalue);
            parameters.Add("product_id", this.ProductId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
        }

        #endregion
    }
}
