using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.category.redefining.getallchildattributesresult
    /// </summary>
    public class AliexpressCategoryRedefiningGetallchildattributesresultRequest : BaseTopRequest<Top.Api.Response.AliexpressCategoryRedefiningGetallchildattributesresultResponse>
    {
        /// <summary>
        /// 叶子类目ID。通过产品获取类目ID，如果只传cid，则返回一级属性。
        /// </summary>
        public Nullable<long> CateId { get; set; }

        /// <summary>
        /// 获取属性值文本对应的多语言信息
        /// </summary>
        public string Locale { get; set; }

        /// <summary>
        /// 类目子属性路径,由该子属性上层的类目属性id和类目属性值id组成,格式参考示例，多个用逗号隔开，第二个属性及为第一个的属性值的子属性，第三个属性为第二个属性的子属性，以此类推。如需返回此类目对应的子属性，则需同cateid一起进行提交。
        /// </summary>
        public string ParentAttrvalueList { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.category.redefining.getallchildattributesresult";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cate_id", this.CateId);
            parameters.Add("locale", this.Locale);
            parameters.Add("parent_attrvalue_list", this.ParentAttrvalueList);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("cate_id", this.CateId);
            RequestValidator.ValidateMaxListSize("parent_attrvalue_list", this.ParentAttrvalueList, 20);
        }

        #endregion
    }
}
