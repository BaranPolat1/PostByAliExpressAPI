using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.postproduct.redefining.categoryforecast
    /// </summary>
    public class AliexpressPostproductRedefiningCategoryforecastRequest : BaseTopRequest<Top.Api.Response.AliexpressPostproductRedefiningCategoryforecastResponse>
    {
        /// <summary>
        /// 预测模式=1，精准预测； 模式=2，模糊预测；不填写时，默认为1
        /// </summary>
        public string ForecastMode { get; set; }

        /// <summary>
        /// 是否过滤类目准入权限N=不过滤|Y=过滤，不填写时，默认为N
        /// </summary>
        public string IsFilterByPermission { get; set; }

        /// <summary>
        /// 商品标题语言:en，ru，pt，id，es，fr，it，de，nl，tr，he，ja，ar，th，vi，ko，pl  默认为es
        /// </summary>
        public string Locale { get; set; }

        /// <summary>
        /// 商品标题
        /// </summary>
        public string Subject { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.postproduct.redefining.categoryforecast";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("forecast_mode", this.ForecastMode);
            parameters.Add("is_filter_by_permission", this.IsFilterByPermission);
            parameters.Add("locale", this.Locale);
            parameters.Add("subject", this.Subject);
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
