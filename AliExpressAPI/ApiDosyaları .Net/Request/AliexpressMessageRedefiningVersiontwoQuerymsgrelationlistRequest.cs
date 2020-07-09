using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.message.redefining.versiontwo.querymsgrelationlist
    /// </summary>
    public class AliexpressMessageRedefiningVersiontwoQuerymsgrelationlistRequest : BaseTopRequest<Top.Api.Response.AliexpressMessageRedefiningVersiontwoQuerymsgrelationlistResponse>
    {
        /// <summary>
        /// 查询入参对象
        /// </summary>
        public string Query { get; set; }

        public RelationQueryDtoDomain Query_ { set { this.Query = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.message.redefining.versiontwo.querymsgrelationlist";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("query", this.Query);
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
/// RelationQueryDtoDomain Data Structure.
/// </summary>
[Serializable]

public class RelationQueryDtoDomain : TopObject
{
	        /// <summary>
	        /// 当前页码
	        /// </summary>
	        [XmlElement("current_page")]
	        public Nullable<long> CurrentPage { get; set; }
	
	        /// <summary>
	        /// 会话时间查询范围－截至时间，如果不填则取当前时间，从1970年起计算的毫秒时间戳
	        /// </summary>
	        [XmlElement("end_time")]
	        public Nullable<long> EndTime { get; set; }
	
	        /// <summary>
	        /// 是否只查询未处理会话
	        /// </summary>
	        [XmlElement("only_un_dealed")]
	        public Nullable<bool> OnlyUnDealed { get; set; }
	
	        /// <summary>
	        /// 是否只查询未读会话
	        /// </summary>
	        [XmlElement("only_un_readed")]
	        public Nullable<bool> OnlyUnReaded { get; set; }
	
	        /// <summary>
	        /// 每页条数,pageSize取值范围(0~100) 最多返回前5000条数据
	        /// </summary>
	        [XmlElement("page_size")]
	        public Nullable<long> PageSize { get; set; }
	
	        /// <summary>
	        /// 标签值(0,1,2,3,4,5)依次表示为白，红，橙，绿，蓝，紫
	        /// </summary>
	        [XmlElement("rank")]
	        public string Rank { get; set; }
	
	        /// <summary>
	        /// 指定查询某帐号的会话列表，如果不填则返回整个店铺所有帐号的会话列表
	        /// </summary>
	        [XmlElement("seller_id")]
	        public string SellerId { get; set; }
	
	        /// <summary>
	        /// 会话时间查询范围－截至时间，如果不填则取当前时间，从1970年起计算的毫秒时间戳
	        /// </summary>
	        [XmlElement("start_time")]
	        public Nullable<long> StartTime { get; set; }
}

        #endregion
    }
}
