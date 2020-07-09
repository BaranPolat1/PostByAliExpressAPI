using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressSolutionSchemaProductFullUpdateResponse.
    /// </summary>
    public class AliexpressSolutionSchemaProductFullUpdateResponse : TopResponse
    {
        /// <summary>
        /// Product id that has been updated.
        /// </summary>
        [XmlElement("product_id")]
        public long ProductId { get; set; }

    }
}
