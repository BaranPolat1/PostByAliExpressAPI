using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.message.redefining.versiontwo.updatemsgprocessed
    /// </summary>
    public class AliexpressMessageRedefiningVersiontwoUpdatemsgprocessedRequest : BaseTopRequest<Top.Api.Response.AliexpressMessageRedefiningVersiontwoUpdatemsgprocessedResponse>
    {
        /// <summary>
        /// 通道ID(即关系ID)
        /// </summary>
        public string ChannelId { get; set; }

        /// <summary>
        /// 处理状态(0未处理,1已处理)
        /// </summary>
        public string DealStat { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.message.redefining.versiontwo.updatemsgprocessed";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("channel_id", this.ChannelId);
            parameters.Add("deal_stat", this.DealStat);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("channel_id", this.ChannelId);
            RequestValidator.ValidateRequired("deal_stat", this.DealStat);
        }

        #endregion
    }
}
