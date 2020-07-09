using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.evaluation.evaluation.reply
    /// </summary>
    public class AliexpressEvaluationEvaluationReplyRequest : BaseTopRequest<Top.Api.Response.AliexpressEvaluationEvaluationReplyResponse>
    {
        /// <summary>
        /// 要回复的子订单id
        /// </summary>
        public Nullable<long> ChildOrderId { get; set; }

        /// <summary>
        /// 父订单id
        /// </summary>
        public Nullable<long> ParentOrderId { get; set; }

        /// <summary>
        /// 回复内容
        /// </summary>
        public string Text { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.evaluation.evaluation.reply";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("child_order_id", this.ChildOrderId);
            parameters.Add("parent_order_id", this.ParentOrderId);
            parameters.Add("text", this.Text);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("child_order_id", this.ChildOrderId);
            RequestValidator.ValidateRequired("parent_order_id", this.ParentOrderId);
            RequestValidator.ValidateRequired("text", this.Text);
        }

        #endregion
    }
}
