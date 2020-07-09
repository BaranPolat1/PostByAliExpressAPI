using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.photobank.redefining.uploadimage
    /// </summary>
    public class AliexpressPhotobankRedefiningUploadimageRequest : BaseTopRequest<AliexpressPhotobankRedefiningUploadimageResponse>, ITopUploadRequest<AliexpressPhotobankRedefiningUploadimageResponse>
    {
        /// <summary>
        /// 上传文件名称，长度不要超过256个字符。
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// 图片保存的图片组，groupId为空，则图片保存在Other组中。
        /// </summary>
        public string GroupId { get; set; }

        /// <summary>
        /// 图片文件的字节流图片大小限制：3MB
        /// </summary>
        public FileItem ImageBytes { get; set; }

        #region BaseTopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.photobank.redefining.uploadimage";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("file_name", this.FileName);
            parameters.Add("group_id", this.GroupId);
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
