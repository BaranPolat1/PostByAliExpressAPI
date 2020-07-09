using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressFreightRedefiningListfreighttemplateResponse.
    /// </summary>
    public class AliexpressFreightRedefiningListfreighttemplateResponse : TopResponse
    {
        /// <summary>
        /// aeopFreightTemplateDTOList
        /// </summary>
        [XmlArray("aeop_freight_template_d_t_o_list")]
        [XmlArrayItem("aeopfreighttemplatedtolist")]
        public List<AeopfreighttemplatedtolistDomain> AeopFreightTemplateDTOList { get; set; }

        /// <summary>
        /// errorDesc
        /// </summary>
        [XmlElement("result_error_desc")]
        public string ResultErrorDesc { get; set; }

        /// <summary>
        /// success
        /// </summary>
        [XmlElement("result_success")]
        public bool ResultSuccess { get; set; }

	/// <summary>
/// AeopfreighttemplatedtolistDomain Data Structure.
/// </summary>
[Serializable]

public class AeopfreighttemplatedtolistDomain : TopObject
{
	        /// <summary>
	        /// is_default
	        /// </summary>
	        [XmlElement("is_default")]
	        public bool IsDefault { get; set; }
	
	        /// <summary>
	        /// templateId
	        /// </summary>
	        [XmlElement("template_id")]
	        public long TemplateId { get; set; }
	
	        /// <summary>
	        /// templateName
	        /// </summary>
	        [XmlElement("template_name")]
	        public string TemplateName { get; set; }
}

    }
}
