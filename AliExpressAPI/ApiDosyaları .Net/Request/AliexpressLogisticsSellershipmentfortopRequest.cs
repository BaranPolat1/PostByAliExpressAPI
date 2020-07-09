using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.logistics.sellershipmentfortop
    /// </summary>
    public class AliexpressLogisticsSellershipmentfortopRequest : BaseTopRequest<Top.Api.Response.AliexpressLogisticsSellershipmentfortopResponse>
    {
        /// <summary>
        /// memo
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 国际运单号
        /// </summary>
        public string LogisticsNo { get; set; }

        /// <summary>
        /// 交易订单号
        /// </summary>
        public string OutRef { get; set; }

        /// <summary>
        /// 包裹类型
        /// </summary>
        public string PackageType { get; set; }

        /// <summary>
        /// 声明发货类型，all表示全部发货，part表示部分声明发货。
        /// </summary>
        public string SendType { get; set; }

        /// <summary>
        /// 物流服务名称
        /// </summary>
        public string ServiceName { get; set; }

        /// <summary>
        /// 追踪网址
        /// </summary>
        public string TrackingWebsite { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.logistics.sellershipmentfortop";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("description", this.Description);
            parameters.Add("logistics_no", this.LogisticsNo);
            parameters.Add("out_ref", this.OutRef);
            parameters.Add("package_type", this.PackageType);
            parameters.Add("send_type", this.SendType);
            parameters.Add("service_name", this.ServiceName);
            parameters.Add("tracking_website", this.TrackingWebsite);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("logistics_no", this.LogisticsNo);
            RequestValidator.ValidateRequired("out_ref", this.OutRef);
            RequestValidator.ValidateRequired("send_type", this.SendType);
            RequestValidator.ValidateRequired("service_name", this.ServiceName);
        }

        #endregion
    }
}
