using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.image.redefining.uploadtempimageforsdk
    /// </summary>
    public class AliexpressImageRedefiningUploadtempimageforsdkRequest : BaseTopRequest<AliexpressImageRedefiningUploadtempimageforsdkResponse>, ITopUploadRequest<AliexpressImageRedefiningUploadtempimageforsdkResponse>
    {
        /// <summary>
        /// 字符串形式的图片文件二进制数据流
        /// </summary>
        public FileItem FileData { get; set; }

        /// <summary>
        /// 图片原名。支持的图片格式：jpg, jpeg, gif
        /// </summary>
        public string SrcFileName { get; set; }

        #region BaseTopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.image.redefining.uploadtempimageforsdk";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("src_file_name", this.SrcFileName);
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
            parameters.Add("file_data", this.FileData);
            return parameters;
        }

        #endregion
    }
}
