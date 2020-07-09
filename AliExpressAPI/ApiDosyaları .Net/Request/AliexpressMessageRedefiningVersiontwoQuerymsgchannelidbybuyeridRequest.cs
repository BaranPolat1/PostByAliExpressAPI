using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.message.redefining.versiontwo.querymsgchannelidbybuyerid
    /// </summary>
    public class AliexpressMessageRedefiningVersiontwoQuerymsgchannelidbybuyeridRequest : BaseTopRequest<Top.Api.Response.AliexpressMessageRedefiningVersiontwoQuerymsgchannelidbybuyeridResponse>
    {
        /// <summary>
        /// 用户登陆账号
        /// </summary>
        public string BuyerId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.message.redefining.versiontwo.querymsgchannelidbybuyerid";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("buyer_id", this.BuyerId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("buyer_id", this.BuyerId);
        }

        #endregion
    }
}
