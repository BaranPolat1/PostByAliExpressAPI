using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.solution.feed.query
    /// </summary>
    public class AliexpressSolutionFeedQueryRequest : BaseTopRequest<Top.Api.Response.AliexpressSolutionFeedQueryResponse>
    {
        /// <summary>
        /// job id
        /// </summary>
        public Nullable<long> JobId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.solution.feed.query";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("job_id", this.JobId);
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
