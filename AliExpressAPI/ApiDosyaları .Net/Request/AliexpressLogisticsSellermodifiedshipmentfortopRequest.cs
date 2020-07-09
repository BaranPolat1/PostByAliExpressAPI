using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.logistics.sellermodifiedshipmentfortop
    /// </summary>
    public class AliexpressLogisticsSellermodifiedshipmentfortopRequest : BaseTopRequest<Top.Api.Response.AliexpressLogisticsSellermodifiedshipmentfortopResponse>
    {
        /// <summary>
        /// memo
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 新的运单号
        /// </summary>
        public string NewLogisticsNo { get; set; }

        /// <summary>
        /// 新的发货物流服务
        /// </summary>
        public string NewServiceName { get; set; }

        /// <summary>
        /// 旧的运单号
        /// </summary>
        public string OldLogisticsNo { get; set; }

        /// <summary>
        /// 用户需要修改的的老的发货物流服务
        /// </summary>
        public string OldServiceName { get; set; }

        /// <summary>
        /// 交易订单号
        /// </summary>
        public string OutRef { get; set; }

        /// <summary>
        /// 包裹类型
        /// </summary>
        public string PackageType { get; set; }

        /// <summary>
        /// 状态包括：全部发货(all)、部分发货(part)
        /// </summary>
        public string SendType { get; set; }

        /// <summary>
        /// 跟踪网址
        /// </summary>
        public string TrackingWebsite { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.logistics.sellermodifiedshipmentfortop";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("description", this.Description);
            parameters.Add("new_logistics_no", this.NewLogisticsNo);
            parameters.Add("new_service_name", this.NewServiceName);
            parameters.Add("old_logistics_no", this.OldLogisticsNo);
            parameters.Add("old_service_name", this.OldServiceName);
            parameters.Add("out_ref", this.OutRef);
            parameters.Add("package_type", this.PackageType);
            parameters.Add("send_type", this.SendType);
            parameters.Add("tracking_website", this.TrackingWebsite);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("new_logistics_no", this.NewLogisticsNo);
            RequestValidator.ValidateRequired("new_service_name", this.NewServiceName);
            RequestValidator.ValidateRequired("old_logistics_no", this.OldLogisticsNo);
            RequestValidator.ValidateRequired("old_service_name", this.OldServiceName);
            RequestValidator.ValidateRequired("out_ref", this.OutRef);
            RequestValidator.ValidateRequired("send_type", this.SendType);
        }

        #endregion
    }
}
