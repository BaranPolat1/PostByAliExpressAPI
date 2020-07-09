using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressMerchantOverseaBrandGetResponse.
    /// </summary>
    public class AliexpressMerchantOverseaBrandGetResponse : TopResponse
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlElement("result")]
        public ResultDtoDomain Result { get; set; }

	/// <summary>
/// BrandQualificationDtoDomain Data Structure.
/// </summary>
[Serializable]

public class BrandQualificationDtoDomain : TopObject
{
	        /// <summary>
	        /// 品牌id
	        /// </summary>
	        [XmlElement("brand_id")]
	        public long BrandId { get; set; }
	
	        /// <summary>
	        /// 品牌名称
	        /// </summary>
	        [XmlElement("brand_name")]
	        public string BrandName { get; set; }
	
	        /// <summary>
	        /// 过期日期：yyyy-MM-dd
	        /// </summary>
	        [XmlElement("invalid_time_str")]
	        public string InvalidTimeStr { get; set; }
}

	/// <summary>
/// ResultDtoDomain Data Structure.
/// </summary>
[Serializable]

public class ResultDtoDomain : TopObject
{
	        /// <summary>
	        /// 结果数据
	        /// </summary>
	        [XmlArray("datas")]
	        [XmlArrayItem("brand_qualification_dto")]
	        public List<BrandQualificationDtoDomain> Datas { get; set; }
}

    }
}
