using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.message.redefining.versiontwo.updatemsgrank
    /// </summary>
    public class AliexpressMessageRedefiningVersiontwoUpdatemsgrankRequest : BaseTopRequest<Top.Api.Response.AliexpressMessageRedefiningVersiontwoUpdatemsgrankResponse>
    {
        /// <summary>
        /// 通道ID(即关系ID)
        /// </summary>
        public string ChannelId { get; set; }

        /// <summary>
        /// 标签值(0,1,2,3,4,5)依次表示为白，红，橙，绿，蓝，紫
        /// </summary>
        public string Rank { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.message.redefining.versiontwo.updatemsgrank";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("channel_id", this.ChannelId);
            parameters.Add("rank", this.Rank);
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
