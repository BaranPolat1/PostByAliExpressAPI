using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressLogisticsRedefiningQureywlbdomesticlogisticscompanyResponse.
    /// </summary>
    public class AliexpressLogisticsRedefiningQureywlbdomesticlogisticscompanyResponse : TopResponse
    {
        /// <summary>
        /// error description
        /// </summary>
        [XmlElement("error_desc")]
        public string ErrorDesc { get; set; }

        /// <summary>
        /// result
        /// </summary>
        [XmlArray("result_list")]
        [XmlArrayItem("result")]
        public List<ResultDomain> ResultList { get; set; }

        /// <summary>
        /// success
        /// </summary>
        [XmlElement("result_success")]
        public bool ResultSuccess { get; set; }

	/// <summary>
/// ResultDomain Data Structure.
/// </summary>
[Serializable]

public class ResultDomain : TopObject
{
	        /// <summary>
	        /// companyCode
	        /// </summary>
	        [XmlElement("company_code")]
	        public string CompanyCode { get; set; }
	
	        /// <summary>
	        /// companyId
	        /// </summary>
	        [XmlElement("company_id")]
	        public long CompanyId { get; set; }
	
	        /// <summary>
	        /// name
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
}

    }
}
