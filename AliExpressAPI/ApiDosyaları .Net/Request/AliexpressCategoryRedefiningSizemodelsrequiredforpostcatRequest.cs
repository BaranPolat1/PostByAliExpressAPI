using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.category.redefining.sizemodelsrequiredforpostcat
    /// </summary>
    public class AliexpressCategoryRedefiningSizemodelsrequiredforpostcatRequest : BaseTopRequest<Top.Api.Response.AliexpressCategoryRedefiningSizemodelsrequiredforpostcatResponse>
    {
        /// <summary>
        /// 叶子发布类目ID
        /// </summary>
        public Nullable<long> Param0 { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.category.redefining.sizemodelsrequiredforpostcat";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("param0", this.Param0);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("param0", this.Param0);
        }

        #endregion
    }
}
