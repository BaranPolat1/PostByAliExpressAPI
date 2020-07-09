using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressTradeRedefiningExtendsbuyeracceptgoodstimeResponse.
    /// </summary>
    public class AliexpressTradeRedefiningExtendsbuyeracceptgoodstimeResponse : TopResponse
    {
        /// <summary>
        /// 是否成功true/false
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 错误详细说明
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 错误码(100:查询无此订单ID;200:业务数据错误，无对应的业务数据;201:延长时间超过了系统允许时间;210:业务数据错误 无法执行此操作;601:查询该帐号无权限进行数据修改)
        /// </summary>
        [XmlElement("sub_error_code")]
        public long SubErrorCode { get; set; }

    }
}
