using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressCategoryRedefiningSizemodelsrequiredforpostcatResponse.
    /// </summary>
    public class AliexpressCategoryRedefiningSizemodelsrequiredforpostcatResponse : TopResponse
    {
        /// <summary>
        /// 类目必须尺码表
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }

    }
}
