using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressSolutionSellerCategoryTreeQueryResponse.
    /// </summary>
    public class AliexpressSolutionSellerCategoryTreeQueryResponse : TopResponse
    {
        /// <summary>
        /// children category list under category_id
        /// </summary>
        [XmlArray("children_category_list")]
        [XmlArrayItem("category_info")]
        public List<CategoryInfoDomain> ChildrenCategoryList { get; set; }

        /// <summary>
        /// whether success or not
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }

	/// <summary>
/// CategoryInfoDomain Data Structure.
/// </summary>
[Serializable]

public class CategoryInfoDomain : TopObject
{
	        /// <summary>
	        /// category id
	        /// </summary>
	        [XmlElement("children_category_id")]
	        public long ChildrenCategoryId { get; set; }
	
	        /// <summary>
	        /// whether the category is leaf or not
	        /// </summary>
	        [XmlElement("is_leaf_category")]
	        public bool IsLeafCategory { get; set; }
	
	        /// <summary>
	        /// level of the categories. As for root categories, the level is 1
	        /// </summary>
	        [XmlElement("level")]
	        public long Level { get; set; }
	
	        /// <summary>
	        /// multi langauge names of the categories
	        /// </summary>
	        [XmlElement("multi_language_names")]
	        public string MultiLanguageNames { get; set; }
}

    }
}
