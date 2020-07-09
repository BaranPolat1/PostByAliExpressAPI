using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.postproduct.redefining.findaeproductdetailmodulelistbyqurey
    /// </summary>
    public class AliexpressPostproductRedefiningFindaeproductdetailmodulelistbyqureyRequest : BaseTopRequest<Top.Api.Response.AliexpressPostproductRedefiningFindaeproductdetailmodulelistbyqureyResponse>
    {
        /// <summary>
        /// 要查询模块的状态，包含：tbd(审核不通过),auditing（审核中）,approved（审核通过）
        /// </summary>
        public string ModuleStatus { get; set; }

        /// <summary>
        /// 要查询当前页码，每页返回50条记录，从1开始
        /// </summary>
        public Nullable<long> PageIndex { get; set; }

        /// <summary>
        /// 要查询模块的类型，包含：custom（自定义模块）,relation（关联模块）
        /// </summary>
        public string Type { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.postproduct.redefining.findaeproductdetailmodulelistbyqurey";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("module_status", this.ModuleStatus);
            parameters.Add("page_index", this.PageIndex);
            parameters.Add("type", this.Type);
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
