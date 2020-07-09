using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressMessageRedefiningVersiontwoQuerymsgdetaillistbybuyeridResponse.
    /// </summary>
    public class AliexpressMessageRedefiningVersiontwoQuerymsgdetaillistbybuyeridResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public OpenApiMessageDetailListResultDomain Result { get; set; }

	/// <summary>
/// SummaryDomain Data Structure.
/// </summary>
[Serializable]

public class SummaryDomain : TopObject
{
	        /// <summary>
	        /// 订单链接
	        /// </summary>
	        [XmlElement("order_url")]
	        public string OrderUrl { get; set; }
	
	        /// <summary>
	        /// 商品详情链接
	        /// </summary>
	        [XmlElement("product_detail_url")]
	        public string ProductDetailUrl { get; set; }
	
	        /// <summary>
	        /// 商品图片链接
	        /// </summary>
	        [XmlElement("product_image_url")]
	        public string ProductImageUrl { get; set; }
	
	        /// <summary>
	        /// 商品名称
	        /// </summary>
	        [XmlElement("product_name")]
	        public string ProductName { get; set; }
	
	        /// <summary>
	        /// 消息接收者ID
	        /// </summary>
	        [XmlElement("receiver_ali_id")]
	        public long ReceiverAliId { get; set; }
	
	        /// <summary>
	        /// 消息接收者名字
	        /// </summary>
	        [XmlElement("receiver_name")]
	        public string ReceiverName { get; set; }
	
	        /// <summary>
	        /// 消息发送者ID
	        /// </summary>
	        [XmlElement("sender_ali_id")]
	        public long SenderAliId { get; set; }
	
	        /// <summary>
	        /// 消息发送者账号
	        /// </summary>
	        [XmlElement("sender_login_id")]
	        public string SenderLoginId { get; set; }
	
	        /// <summary>
	        /// 消息发送者名字
	        /// </summary>
	        [XmlElement("sender_name")]
	        public string SenderName { get; set; }
}

	/// <summary>
/// FilePathDomain Data Structure.
/// </summary>
[Serializable]

public class FilePathDomain : TopObject
{
	        /// <summary>
	        /// 大图
	        /// </summary>
	        [XmlElement("l_path")]
	        public string LPath { get; set; }
	
	        /// <summary>
	        /// 中图
	        /// </summary>
	        [XmlElement("m_path")]
	        public string MPath { get; set; }
	
	        /// <summary>
	        /// 小图
	        /// </summary>
	        [XmlElement("s_path")]
	        public string SPath { get; set; }
}

	/// <summary>
/// MessageDetailDomain Data Structure.
/// </summary>
[Serializable]

public class MessageDetailDomain : TopObject
{
	        /// <summary>
	        /// 消息内容
	        /// </summary>
	        [XmlElement("content")]
	        public string Content { get; set; }
	
	        /// <summary>
	        /// 扩展ID，如messageType=product, extern_id为productId,如messageType=order, extern_id为orderId;如messageType=member,则为空;对应summary中有相应的附属信息，如为product,则有产品相关的信息；如为order,则有订单相关信息
	        /// </summary>
	        [XmlElement("extern_id")]
	        public long ExternId { get; set; }
	
	        /// <summary>
	        /// filePath
	        /// </summary>
	        [XmlArray("file_path_list")]
	        [XmlArrayItem("file_path")]
	        public List<FilePathDomain> FilePathList { get; set; }
	
	        /// <summary>
	        /// 创建时间
	        /// </summary>
	        [XmlElement("gmt_create")]
	        public long GmtCreate { get; set; }
	
	        /// <summary>
	        /// 消息ID
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 消息类别(product/order/member)
	        /// </summary>
	        [XmlElement("message_type")]
	        public string MessageType { get; set; }
	
	        /// <summary>
	        /// 消息发送者ID
	        /// </summary>
	        [XmlElement("sender_ali_id")]
	        public long SenderAliId { get; set; }
	
	        /// <summary>
	        /// 消息发送者名称
	        /// </summary>
	        [XmlElement("sender_name")]
	        public string SenderName { get; set; }
	
	        /// <summary>
	        /// 摘要
	        /// </summary>
	        [XmlElement("summary")]
	        public SummaryDomain Summary { get; set; }
}

	/// <summary>
/// OpenApiMessageDetailListResultDomain Data Structure.
/// </summary>
[Serializable]

public class OpenApiMessageDetailListResultDomain : TopObject
{
	        /// <summary>
	        /// 错误码
	        /// </summary>
	        [XmlElement("error_code")]
	        public long ErrorCode { get; set; }
	
	        /// <summary>
	        /// 错误信息
	        /// </summary>
	        [XmlElement("error_msg")]
	        public string ErrorMsg { get; set; }
	
	        /// <summary>
	        /// 是否成功
	        /// </summary>
	        [XmlElement("is_success")]
	        public bool IsSuccess { get; set; }
	
	        /// <summary>
	        /// 消息详情列表
	        /// </summary>
	        [XmlArray("message_detail_list")]
	        [XmlArrayItem("message_detail")]
	        public List<MessageDetailDomain> MessageDetailList { get; set; }
}

    }
}
