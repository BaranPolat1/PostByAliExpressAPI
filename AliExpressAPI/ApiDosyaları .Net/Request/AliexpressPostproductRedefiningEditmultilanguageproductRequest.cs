using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.postproduct.redefining.editmultilanguageproduct
    /// </summary>
    public class AliexpressPostproductRedefiningEditmultilanguageproductRequest : BaseTopRequest<Top.Api.Response.AliexpressPostproductRedefiningEditmultilanguageproductResponse>
    {
        /// <summary>
        /// 商品多语言信息
        /// </summary>
        public string AeopAEProductMultilanguageInfo { get; set; }

        public AeopAeProductMultilanguageInfoDomain AeopAEProductMultilanguageInfo_ { set { this.AeopAEProductMultilanguageInfo = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 待编辑的商品ID。
        /// </summary>
        public Nullable<long> ProductId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.postproduct.redefining.editmultilanguageproduct";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("aeop_a_e_product_multilanguage_info", this.AeopAEProductMultilanguageInfo);
            parameters.Add("product_id", this.ProductId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("aeop_a_e_product_multilanguage_info", this.AeopAEProductMultilanguageInfo);
            RequestValidator.ValidateRequired("product_id", this.ProductId);
        }

	/// <summary>
/// AeopAeProductMultilanguageInfoDomain Data Structure.
/// </summary>
[Serializable]

public class AeopAeProductMultilanguageInfoDomain : TopObject
{
	        /// <summary>
	        /// 商品对应语种的详描
	        /// </summary>
	        [XmlElement("detail")]
	        public string Detail { get; set; }
	
	        /// <summary>
	        /// 语种，合法的参数有: ru_RU(俄语);pt_BR(葡语);fr_FR(法语);es_ES(西班牙语);in_ID(印尼语);it_IT(意大利语);de_DE(德语);nl_NL(荷兰语);tr_TR(土耳其语);iw_IL(以色列语);ja_JP(日语);ar_MA(阿拉伯语);th_TH(泰语);vi_VN(越南语);ko_KR(韩语);
	        /// </summary>
	        [XmlElement("locale")]
	        public string Locale { get; set; }
	
	        /// <summary>
	        /// 商品对应语种的无线端详描（json格式），如要清空无线详描请传""空串
	        /// </summary>
	        [XmlElement("mobile_detail")]
	        public string MobileDetail { get; set; }
	
	        /// <summary>
	        /// 商品对应语种的标题, 长度控制在1～218个字符之间。
	        /// </summary>
	        [XmlElement("subject")]
	        public string Subject { get; set; }
}

        #endregion
    }
}
