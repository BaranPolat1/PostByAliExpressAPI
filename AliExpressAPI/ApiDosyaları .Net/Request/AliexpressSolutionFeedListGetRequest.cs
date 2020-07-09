using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.solution.feed.list.get
    /// </summary>
    public class AliexpressSolutionFeedListGetRequest : BaseTopRequest<Top.Api.Response.AliexpressSolutionFeedListGetResponse>
    {
        /// <summary>
        /// current page
        /// </summary>
        public Nullable<long> CurrentPage { get; set; }

        /// <summary>
        /// feed type
        /// </summary>
        public string FeedType { get; set; }

        /// <summary>
        /// page size
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// status of the job, currently there are 3 types: FINISH, PROCESSING, QUEUEING
        /// </summary>
        public string Status { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.solution.feed.list.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("current_page", this.CurrentPage);
            parameters.Add("feed_type", this.FeedType);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("status", this.Status);
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
