using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.trade.redefining.extendsbuyeracceptgoodstime
    /// </summary>
    public class AliexpressTradeRedefiningExtendsbuyeracceptgoodstimeRequest : BaseTopRequest<Top.Api.Response.AliexpressTradeRedefiningExtendsbuyeracceptgoodstimeResponse>
    {
        /// <summary>
        /// 需要延长收货时间的订单ID
        /// </summary>
        public Nullable<long> Param0 { get; set; }

        /// <summary>
        /// 请求延长的具体天数
        /// </summary>
        public Nullable<long> Param1 { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.trade.redefining.extendsbuyeracceptgoodstime";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("param0", this.Param0);
            parameters.Add("param1", this.Param1);
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
