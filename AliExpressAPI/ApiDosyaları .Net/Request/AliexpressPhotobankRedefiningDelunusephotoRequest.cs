using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.photobank.redefining.delunusephoto
    /// </summary>
    public class AliexpressPhotobankRedefiningDelunusephotoRequest : BaseTopRequest<Top.Api.Response.AliexpressPhotobankRedefiningDelunusephotoResponse>
    {
        /// <summary>
        /// none
        /// </summary>
        public string AeopDeleteImageRequest { get; set; }

        public AeopDeleteImageRequestDomain AeopDeleteImageRequest_ { set { this.AeopDeleteImageRequest = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.photobank.redefining.delunusephoto";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("aeop_delete_image_request", this.AeopDeleteImageRequest);
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
/// AeopDeleteImageRequestDomain Data Structure.
/// </summary>
[Serializable]

public class AeopDeleteImageRequestDomain : TopObject
{
	        /// <summary>
	        /// 图片ID(通过“图片银行列表分页查询”接口进行获取，出参中“ iid:图片”为图片ID。
	        /// </summary>
	        [XmlElement("image_repository_id")]
	        public Nullable<long> ImageRepositoryId { get; set; }
}

        #endregion
    }
}
