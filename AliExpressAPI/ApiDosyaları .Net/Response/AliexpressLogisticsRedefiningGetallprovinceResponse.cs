using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressLogisticsRedefiningGetallprovinceResponse.
    /// </summary>
    public class AliexpressLogisticsRedefiningGetallprovinceResponse : TopResponse
    {
        /// <summary>
        /// error description
        /// </summary>
        [XmlElement("error_desc")]
        public string ErrorDesc { get; set; }

        /// <summary>
        /// is success
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }

        /// <summary>
        /// result
        /// </summary>
        [XmlArray("result_list")]
        [XmlArrayItem("result")]
        public List<ResultDomain> ResultList { get; set; }

	/// <summary>
/// ResultDomain Data Structure.
/// </summary>
[Serializable]

public class ResultDomain : TopObject
{
	        /// <summary>
	        /// areaId
	        /// </summary>
	        [XmlElement("area_id")]
	        public long AreaId { get; set; }
	
	        /// <summary>
	        /// cnDiplayName
	        /// </summary>
	        [XmlElement("cn_diplay_name")]
	        public string CnDiplayName { get; set; }
	
	        /// <summary>
	        /// pyDiplayName
	        /// </summary>
	        [XmlElement("py_diplay_name")]
	        public string PyDiplayName { get; set; }
}

    }
}
