using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressMessageRedefiningVersiontwoQuerymsgrelationlistResponse.
    /// </summary>
    public class AliexpressMessageRedefiningVersiontwoQuerymsgrelationlistResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public OpenApiRelationResultDomain Result { get; set; }

	/// <summary>
/// RelationResultDomain Data Structure.
/// </summary>
[Serializable]

public class RelationResultDomain : TopObject
{
	        /// <summary>
	        /// 通道ID，即关系ID
	        /// </summary>
	        [XmlElement("channel_id")]
	        public string ChannelId { get; set; }
	
	        /// <summary>
	        /// 消息所属账号(主账号查询默认包含子账号的信息，如果属于子账号，这里有子账号的ID)
	        /// </summary>
	        [XmlElement("child_id")]
	        public long ChildId { get; set; }
	
	        /// <summary>
	        /// 消息所属账号(主账号查询默认包含子账号的信息，如果属于子账号，这里有子账号的名字)
	        /// </summary>
	        [XmlElement("child_name")]
	        public string ChildName { get; set; }
	
	        /// <summary>
	        /// 处理状态(0未处理,1已处理)
	        /// </summary>
	        [XmlElement("deal_stat")]
	        public string DealStat { get; set; }
	
	        /// <summary>
	        /// 最后一条消息内容
	        /// </summary>
	        [XmlElement("last_message_content")]
	        public string LastMessageContent { get; set; }
	
	        /// <summary>
	        /// 最后一条消息ID
	        /// </summary>
	        [XmlElement("last_message_id")]
	        public long LastMessageId { get; set; }
	
	        /// <summary>
	        /// 最后一条消息是否自己这边发送(true是，false否)
	        /// </summary>
	        [XmlElement("last_message_is_own")]
	        public bool LastMessageIsOwn { get; set; }
	
	        /// <summary>
	        /// 消息发送时间
	        /// </summary>
	        [XmlElement("message_time")]
	        public long MessageTime { get; set; }
	
	        /// <summary>
	        /// 订单ID
	        /// </summary>
	        [XmlElement("order_id")]
	        public long OrderId { get; set; }
	
	        /// <summary>
	        /// 与当前卖家或子账号建立关系的买家ID
	        /// </summary>
	        [XmlElement("other_ali_id")]
	        public long OtherAliId { get; set; }
	
	        /// <summary>
	        /// 与当前卖家或子账号建立关系的买家账号
	        /// </summary>
	        [XmlElement("other_login_id")]
	        public string OtherLoginId { get; set; }
	
	        /// <summary>
	        /// 与当前卖家或子账号建立关系的买家名字
	        /// </summary>
	        [XmlElement("other_name")]
	        public string OtherName { get; set; }
	
	        /// <summary>
	        /// 标签值(0,1,2,3,4,5)依次表示为白，红，橙，绿，蓝，紫
	        /// </summary>
	        [XmlElement("rank")]
	        public string Rank { get; set; }
	
	        /// <summary>
	        /// 未读状态(0未读,1已读)
	        /// </summary>
	        [XmlElement("read_stat")]
	        public string ReadStat { get; set; }
	
	        /// <summary>
	        /// 未读数
	        /// </summary>
	        [XmlElement("unread_count")]
	        public long UnreadCount { get; set; }
}

	/// <summary>
/// OpenApiRelationResultDomain Data Structure.
/// </summary>
[Serializable]

public class OpenApiRelationResultDomain : TopObject
{
	        /// <summary>
	        /// 错误码
	        /// </summary>
	        [XmlElement("error_code")]
	        public long ErrorCode { get; set; }
	
	        /// <summary>
	        /// 错误消息
	        /// </summary>
	        [XmlElement("error_msg")]
	        public string ErrorMsg { get; set; }
	
	        /// <summary>
	        /// success
	        /// </summary>
	        [XmlElement("is_success")]
	        public bool IsSuccess { get; set; }
	
	        /// <summary>
	        /// relation
	        /// </summary>
	        [XmlArray("relation_list")]
	        [XmlArrayItem("relation_result")]
	        public List<RelationResultDomain> RelationList { get; set; }
}

    }
}
