using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressPhotobankRedefiningUploadimageforsdkResponse.
    /// </summary>
    public class AliexpressPhotobankRedefiningUploadimageforsdkResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public AeopUploadImageResponseDomain Result { get; set; }

	/// <summary>
/// AeopUploadImageResponseDomain Data Structure.
/// </summary>
[Serializable]

public class AeopUploadImageResponseDomain : TopObject
{
	        /// <summary>
	        /// 错误代码
	        /// </summary>
	        [XmlElement("error_code")]
	        public long ErrorCode { get; set; }
	
	        /// <summary>
	        /// 错误信息
	        /// </summary>
	        [XmlElement("error_message")]
	        public string ErrorMessage { get; set; }
	
	        /// <summary>
	        /// 图片的名称。
	        /// </summary>
	        [XmlElement("file_name")]
	        public string FileName { get; set; }
	
	        /// <summary>
	        /// 图片的高度。单位：像素
	        /// </summary>
	        [XmlElement("height")]
	        public long Height { get; set; }
	
	        /// <summary>
	        /// isSuccess
	        /// </summary>
	        [XmlElement("is_success")]
	        public bool IsSuccess { get; set; }
	
	        /// <summary>
	        /// 图片银行总的空间大小。单位：MB
	        /// </summary>
	        [XmlElement("photobank_total_size")]
	        public string PhotobankTotalSize { get; set; }
	
	        /// <summary>
	        /// 这张图片的URL。
	        /// </summary>
	        [XmlElement("photobank_url")]
	        public string PhotobankUrl { get; set; }
	
	        /// <summary>
	        /// 已经使用了的图片银行空间。单位：MB
	        /// </summary>
	        [XmlElement("photobank_used_size")]
	        public string PhotobankUsedSize { get; set; }
	
	        /// <summary>
	        /// 图片上传的结果。
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
	
	        /// <summary>
	        /// 图片的宽度。单位：像素
	        /// </summary>
	        [XmlElement("width")]
	        public long Width { get; set; }
}

    }
}
