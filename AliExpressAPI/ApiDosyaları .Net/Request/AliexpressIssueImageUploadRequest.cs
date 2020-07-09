using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.issue.image.upload
    /// </summary>
    public class AliexpressIssueImageUploadRequest : BaseTopRequest<AliexpressIssueImageUploadResponse>, ITopUploadRequest<AliexpressIssueImageUploadResponse>
    {
        /// <summary>
        /// 买家登录帐号
        /// </summary>
        public string BuyerLoginId { get; set; }

        /// <summary>
        /// 文件后缀名
        /// </summary>
        public string Extension { get; set; }

        /// <summary>
        /// 图片内容
        /// </summary>
        public FileItem ImageBytes { get; set; }

        /// <summary>
        /// 纠纷id
        /// </summary>
        public Nullable<long> IssueId { get; set; }

        #region BaseTopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.issue.image.upload";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("buyer_login_id", this.BuyerLoginId);
            parameters.Add("extension", this.Extension);
            parameters.Add("issue_id", this.IssueId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("buyer_login_id", this.BuyerLoginId);
            RequestValidator.ValidateRequired("extension", this.Extension);
            RequestValidator.ValidateRequired("issue_id", this.IssueId);
        }

        #endregion

        #region ITopUploadRequest Members

        public IDictionary<string, FileItem> GetFileParameters()
        {
            IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>();
            parameters.Add("image_bytes", this.ImageBytes);
            return parameters;
        }

        #endregion
    }
}
