using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.category.redefining.getchildattributesresultbypostcateidandpath
    /// </summary>
    public class AliexpressCategoryRedefiningGetchildattributesresultbypostcateidandpathRequest : BaseTopRequest<Top.Api.Response.AliexpressCategoryRedefiningGetchildattributesresultbypostcateidandpathResponse>
    {
        /// <summary>
        /// 指定获取语种的属性值文本
        /// </summary>
        public string Locale { get; set; }

        /// <summary>
        /// 叶子类目ID。通过产品获取类目ID，如果只传cid，则返回一级属性。
        /// </summary>
        public string Param1 { get; set; }

        /// <summary>
        /// 类目子属性路径,由该子属性上层的类目属性id和类目属性值id组成,格式参考示例，多个用逗号隔开，第二个属性及为第一个的属性值的子属性，第三个属性为第二个属性的子属性，以此类推。如需返回此类目对应的子属性，则需同cateid一起进行提交。
        /// </summary>
        public string Param2 { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.category.redefining.getchildattributesresultbypostcateidandpath";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("locale", this.Locale);
            parameters.Add("param1", this.Param1);
            parameters.Add("param2", this.Param2);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateMaxListSize("param2", this.Param2, 20);
        }

        #endregion
    }
}
