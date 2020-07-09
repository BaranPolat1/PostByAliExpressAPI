using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.postproduct.redefining.createproductgroup
    /// </summary>
    public class AliexpressPostproductRedefiningCreateproductgroupRequest : BaseTopRequest<Top.Api.Response.AliexpressPostproductRedefiningCreateproductgroupResponse>
    {
        /// <summary>
        /// 分组的名称, 请控制在1～50个英文字符之内。
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 父分组的ID。如果为0则表示创建根分组，否则创建指定分组下的二级分组。
        /// </summary>
        public Nullable<long> ParentId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.postproduct.redefining.createproductgroup";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("name", this.Name);
            parameters.Add("parent_id", this.ParentId);
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
