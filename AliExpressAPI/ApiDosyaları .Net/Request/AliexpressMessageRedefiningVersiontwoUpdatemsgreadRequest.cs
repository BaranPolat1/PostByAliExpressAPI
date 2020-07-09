using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.message.redefining.versiontwo.updatemsgread
    /// </summary>
    public class AliexpressMessageRedefiningVersiontwoUpdatemsgreadRequest : BaseTopRequest<Top.Api.Response.AliexpressMessageRedefiningVersiontwoUpdatemsgreadResponse>
    {
        /// <summary>
        /// 通道ID，即关系ID
        /// </summary>
        public string ChannelId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.message.redefining.versiontwo.updatemsgread";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("channel_id", this.ChannelId);
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
