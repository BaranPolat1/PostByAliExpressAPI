using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressImageRedefiningUploadtempimageResponse.
    /// </summary>
    public class AliexpressImageRedefiningUploadtempimageResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public AeopImageResponseDomain Result { get; set; }

	/// <summary>
/// AeopImageResponseDomain Data Structure.
/// </summary>
[Serializable]

public class AeopImageResponseDomain : TopObject
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
	        /// 图片的高度。单位：像素
	        /// </summary>
	        [XmlElement("height")]
	        public long Height { get; set; }
	
	        /// <summary>
	        /// 本次操作的结果。
	        /// </summary>
	        [XmlElement("is_success")]
	        public bool IsSuccess { get; set; }
	
	        /// <summary>
	        /// 图片的文件名。
	        /// </summary>
	        [XmlElement("src_file_name")]
	        public string SrcFileName { get; set; }
	
	        /// <summary>
	        /// 图片的URL。
	        /// </summary>
	        [XmlElement("url")]
	        public string Url { get; set; }
	
	        /// <summary>
	        /// 图片的宽度。单位：像素
	        /// </summary>
	        [XmlElement("width")]
	        public long Width { get; set; }
}

    }
}
