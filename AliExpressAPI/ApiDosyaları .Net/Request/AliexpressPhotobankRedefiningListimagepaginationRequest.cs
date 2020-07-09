using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.photobank.redefining.listimagepagination
    /// </summary>
    public class AliexpressPhotobankRedefiningListimagepaginationRequest : BaseTopRequest<Top.Api.Response.AliexpressPhotobankRedefiningListimagepaginationResponse>
    {
        /// <summary>
        /// none
        /// </summary>
        public string AeopImagePaginationRequest { get; set; }

        public AeopImagePaginationRequestDomain AeopImagePaginationRequest_ { set { this.AeopImagePaginationRequest = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.photobank.redefining.listimagepagination";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("aeop_image_pagination_request", this.AeopImagePaginationRequest);
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
/// AeopImagePaginationRequestDomain Data Structure.
/// </summary>
[Serializable]

public class AeopImagePaginationRequestDomain : TopObject
{
	        /// <summary>
	        /// 当前页码
	        /// </summary>
	        [XmlElement("current_page")]
	        public Nullable<long> CurrentPage { get; set; }
	
	        /// <summary>
	        /// 图片组id
	        /// </summary>
	        [XmlElement("group_id")]
	        public string GroupId { get; set; }
	
	        /// <summary>
	        /// 图片存放位置.可选值:allGroup(所有分组), temp(被禁用的图片), subGroup(某一分组), unGroup(非分组). 如果locationType参数值为allGroup,temp,unGroup时，将忽略groupId参数。 如果locationType的参数值为subGroup,须指定groupId参数。
	        /// </summary>
	        [XmlElement("location_type")]
	        public string LocationType { get; set; }
	
	        /// <summary>
	        /// 默认18个，最大值 50
	        /// </summary>
	        [XmlElement("page_size")]
	        public Nullable<long> PageSize { get; set; }
}

        #endregion
    }
}
