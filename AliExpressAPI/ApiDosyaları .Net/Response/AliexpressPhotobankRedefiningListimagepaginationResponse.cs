using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressPhotobankRedefiningListimagepaginationResponse.
    /// </summary>
    public class AliexpressPhotobankRedefiningListimagepaginationResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public AeopImagePaginationResultDomain Result { get; set; }

	/// <summary>
/// AeopImageDomain Data Structure.
/// </summary>
[Serializable]

public class AeopImageDomain : TopObject
{
	        /// <summary>
	        /// 这张图片在图片银行中名称。可以根据这个值在图片银行中搜索到对应的图片。
	        /// </summary>
	        [XmlElement("display_name")]
	        public string DisplayName { get; set; }
	
	        /// <summary>
	        /// 这张图片的大小。单位：字节(B)。
	        /// </summary>
	        [XmlElement("file_size")]
	        public long FileSize { get; set; }
	
	        /// <summary>
	        /// gmtCreate
	        /// </summary>
	        [XmlElement("gmt_create")]
	        public string GmtCreate { get; set; }
	
	        /// <summary>
	        /// gmtModified
	        /// </summary>
	        [XmlElement("gmt_modified")]
	        public string GmtModified { get; set; }
	
	        /// <summary>
	        /// 图片银行产品分组ID
	        /// </summary>
	        [XmlElement("group_id")]
	        public string GroupId { get; set; }
	
	        /// <summary>
	        /// 这张图片的高度。单位：像素。
	        /// </summary>
	        [XmlElement("height")]
	        public long Height { get; set; }
	
	        /// <summary>
	        /// 这张图片在图片银行中的ID。
	        /// </summary>
	        [XmlElement("iid")]
	        public long Iid { get; set; }
	
	        /// <summary>
	        /// 这张图片被引用的次数。
	        /// </summary>
	        [XmlElement("reference_count")]
	        public long ReferenceCount { get; set; }
	
	        /// <summary>
	        /// status
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
	
	        /// <summary>
	        /// 这张图片的URL。可以将这个URL添加到产品的主图或者详描中。
	        /// </summary>
	        [XmlElement("url")]
	        public string Url { get; set; }
	
	        /// <summary>
	        /// 这张图片的宽度。单位：像素。
	        /// </summary>
	        [XmlElement("width")]
	        public long Width { get; set; }
}

	/// <summary>
/// AeopImagePaginationRequestDomain Data Structure.
/// </summary>
[Serializable]

public class AeopImagePaginationRequestDomain : TopObject
{
	        /// <summary>
	        /// 当前页的值
	        /// </summary>
	        [XmlElement("current_page")]
	        public long CurrentPage { get; set; }
	
	        /// <summary>
	        /// 图片银行产品分组ID
	        /// </summary>
	        [XmlElement("group_id")]
	        public string GroupId { get; set; }
	
	        /// <summary>
	        /// locationType
	        /// </summary>
	        [XmlElement("location_type")]
	        public string LocationType { get; set; }
	
	        /// <summary>
	        /// 每页的记录数
	        /// </summary>
	        [XmlElement("page_size")]
	        public long PageSize { get; set; }
}

	/// <summary>
/// AeopImagePaginationResultDomain Data Structure.
/// </summary>
[Serializable]

public class AeopImagePaginationResultDomain : TopObject
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
	        /// 本次查询结果返回的图片列表。
	        /// </summary>
	        [XmlArray("images")]
	        [XmlArrayItem("aeop_image")]
	        public List<AeopImageDomain> Images { get; set; }
	
	        /// <summary>
	        /// 当前参数组成的查询对象。
	        /// </summary>
	        [XmlElement("query")]
	        public AeopImagePaginationRequestDomain Query { get; set; }
	
	        /// <summary>
	        /// 本次调用是否成功。
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
	
	        /// <summary>
	        /// 当前分组下的图片总数。如果locationType取值为"allGroup", 则为这个用户的图片总数。
	        /// </summary>
	        [XmlElement("total")]
	        public long Total { get; set; }
	
	        /// <summary>
	        /// 本次查询结果分页的页数。
	        /// </summary>
	        [XmlElement("total_page")]
	        public long TotalPage { get; set; }
}

    }
}
