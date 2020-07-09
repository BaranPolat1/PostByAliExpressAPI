using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.message.redefining.versiontwo.addmsg
    /// </summary>
    public class AliexpressMessageRedefiningVersiontwoAddmsgRequest : BaseTopRequest<Top.Api.Response.AliexpressMessageRedefiningVersiontwoAddmsgResponse>
    {
        /// <summary>
        /// 消息发送对象
        /// </summary>
        public string CreateParam { get; set; }

        public CreateDtoDomain CreateParam_ { set { this.CreateParam = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.message.redefining.versiontwo.addmsg";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("create_param", this.CreateParam);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
        }

	/// <summary>
/// CreateDtoDomain Data Structure.
/// </summary>
[Serializable]

public class CreateDtoDomain : TopObject
{
	        /// <summary>
	        /// 买家登录帐号
	        /// </summary>
	        [XmlElement("buyer_id")]
	        public string BuyerId { get; set; }
	
	        /// <summary>
	        /// 已废弃
	        /// </summary>
	        [XmlElement("channel_id")]
	        public string ChannelId { get; set; }
	
	        /// <summary>
	        /// 消息内容
	        /// </summary>
	        [XmlElement("content")]
	        public string Content { get; set; }
	
	        /// <summary>
	        /// 针对不同类型填对应关联对象的ID，如果messageType为product时填入productId值(必填)；如果messageType为order时填入orderId值(必填)；如果messageType为member时请输入0
	        /// </summary>
	        [XmlElement("extern_id")]
	        public Nullable<long> ExternId { get; set; }
	
	        /// <summary>
	        /// 图片地址
	        /// </summary>
	        [XmlElement("img_path")]
	        public string ImgPath { get; set; }
	
	        /// <summary>
	        /// 消息类型,product(商品)、member(会员，包含店铺)、order(订单)
	        /// </summary>
	        [XmlElement("message_type")]
	        public string MessageType { get; set; }
	
	        /// <summary>
	        /// 卖家登录帐号
	        /// </summary>
	        [XmlElement("seller_id")]
	        public string SellerId { get; set; }
}

        #endregion
    }
}
