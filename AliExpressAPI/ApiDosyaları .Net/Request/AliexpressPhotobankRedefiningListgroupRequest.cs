using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.photobank.redefining.listgroup
    /// </summary>
    public class AliexpressPhotobankRedefiningListgroupRequest : BaseTopRequest<Top.Api.Response.AliexpressPhotobankRedefiningListgroupResponse>
    {
        /// <summary>
        /// 图片组ID。不填groupId则返回所有图片组信息
        /// </summary>
        public string GroupId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.photobank.redefining.listgroup";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("group_id", this.GroupId);
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
