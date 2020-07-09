using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.photobank.redefining.queryphotobankimagebypaths
    /// </summary>
    public class AliexpressPhotobankRedefiningQueryphotobankimagebypathsRequest : BaseTopRequest<Top.Api.Response.AliexpressPhotobankRedefiningQueryphotobankimagebypathsResponse>
    {
        /// <summary>
        /// 图片文件名，多个文件用逗号分隔
        /// </summary>
        public string Paths { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.photobank.redefining.queryphotobankimagebypaths";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("paths", this.Paths);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateMaxListSize("paths", this.Paths, 20);
        }

        #endregion
    }
}
