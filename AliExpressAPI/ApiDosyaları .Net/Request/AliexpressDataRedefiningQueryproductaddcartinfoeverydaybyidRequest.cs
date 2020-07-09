using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.data.redefining.queryproductaddcartinfoeverydaybyid
    /// </summary>
    public class AliexpressDataRedefiningQueryproductaddcartinfoeverydaybyidRequest : BaseTopRequest<Top.Api.Response.AliexpressDataRedefiningQueryproductaddcartinfoeverydaybyidResponse>
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        public Nullable<long> CurrentPage { get; set; }

        /// <summary>
        /// 查询时间段的截止时间。例如：yyyy-mm-dd
        /// </summary>
        public string EndDate { get; set; }

        /// <summary>
        /// 每页结果数量
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        public string ProductId { get; set; }

        /// <summary>
        /// 查询时间段的开始时间。例如：yyyy-mm-dd
        /// </summary>
        public string StartDate { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.data.redefining.queryproductaddcartinfoeverydaybyid";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("current_page", this.CurrentPage);
            parameters.Add("end_date", this.EndDate);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("product_id", this.ProductId);
            parameters.Add("start_date", this.StartDate);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("current_page", this.CurrentPage);
            RequestValidator.ValidateRequired("end_date", this.EndDate);
            RequestValidator.ValidateRequired("product_id", this.ProductId);
            RequestValidator.ValidateRequired("start_date", this.StartDate);
        }

        #endregion
    }
}
