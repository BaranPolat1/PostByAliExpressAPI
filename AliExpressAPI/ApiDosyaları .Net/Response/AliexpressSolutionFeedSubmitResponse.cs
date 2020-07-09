using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressSolutionFeedSubmitResponse.
    /// </summary>
    public class AliexpressSolutionFeedSubmitResponse : TopResponse
    {
        /// <summary>
        /// job id,which is for querying the job response later.
        /// </summary>
        [XmlElement("job_id")]
        public long JobId { get; set; }

    }
}
