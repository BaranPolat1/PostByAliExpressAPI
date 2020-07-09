using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.logistics.redefining.getnextleveladdressdata
    /// </summary>
    public class AliexpressLogisticsRedefiningGetnextleveladdressdataRequest : BaseTopRequest<Top.Api.Response.AliexpressLogisticsRedefiningGetnextleveladdressdataResponse>
    {
        /// <summary>
        /// area id
        /// </summary>
        public Nullable<long> AreaId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.logistics.redefining.getnextleveladdressdata";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("area_id", this.AreaId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
        }

        #endregion
    }
}
