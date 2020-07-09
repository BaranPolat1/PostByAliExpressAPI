using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.logistics.createwarehouseorder
    /// </summary>
    public class AliexpressLogisticsCreatewarehouseorderRequest : BaseTopRequest<Top.Api.Response.AliexpressLogisticsCreatewarehouseorderResponse>
    {
        /// <summary>
        /// addresses
        /// </summary>
        public string AddressDTOs { get; set; }

        public AddressdtosDomain AddressDTOs_ { set { this.AddressDTOs = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 申报产品信息,列表类型，以json格式来表达。{productId为产品ID(必填,如为礼品,则设置为0);categoryCnDesc为申报中文名称(必填,长度1-20);categoryEnDesc为申报英文名称(必填,长度1-60);productNum产品件数(必填1-999);productDeclareAmount为产品申报金额(必填,0.01-10000.00);productWeight为产品申报重量(必填0.001-2.000);isContainsBattery为是否包含锂电池(必填0/1);scItemId为仓储发货属性代码（团购订单，仓储发货必填，物流服务为RUSTON 哈尔滨备货仓 HRB_WLB_RUSTONHEB，属性代码对应AE商品的sku属性一级，暂时没有提供接口查询属性代码，可以在仓储管理--库存管理页面查看，例如： 团购产品的sku属性White对应属性代码 40414943126）;skuValue为属性名称（团购订单，仓储发货必填，例如：White）;hsCode为产品海关编码，获取相关数据请至：http://www.customs.gov.cn/Tabid/67737/Default.aspx};isAneroidMarkup为是否含非液体化妆品（必填，填0代表不含非液体化妆品；填1代表含非液体化妆品；默认为0）;isOnlyBattery为是否含纯电池产品（必填，填0代表不含纯电池产品；填1代表含纯电池产品；默认为0）;
        /// </summary>
        public string DeclareProductDTOs { get; set; }

        public List<AeopWlDeclareProductForTopDtoDomain> DeclareProductDTOs_ { set { this.DeclareProductDTOs = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 国内快递公司名称,物流公司Id为-1时,必填
        /// </summary>
        public string DomesticLogisticsCompany { get; set; }

        /// <summary>
        /// 国内快递ID(物流公司是other时,ID为-1)
        /// </summary>
        public Nullable<long> DomesticLogisticsCompanyId { get; set; }

        /// <summary>
        /// 国内快递运单号,长度1-32
        /// </summary>
        public string DomesticTrackingNo { get; set; }

        /// <summary>
        /// 发票号（可空）
        /// </summary>
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// 包裹数量： 创建国家小包订单时非必填，创建国家快递订单时必填
        /// </summary>
        public Nullable<long> PackageNum { get; set; }

        /// <summary>
        /// ISV用户唯一标识，一般为userId,最大长度为16个字符
        /// </summary>
        public string TopUserKey { get; set; }

        /// <summary>
        /// 订单来源
        /// </summary>
        public string TradeOrderFrom { get; set; }

        /// <summary>
        /// 交易订单号
        /// </summary>
        public Nullable<long> TradeOrderId { get; set; }

        /// <summary>
        /// 不可达处理(退回:0/销毁:1) 。详情请参考：http://bbs.seller.aliexpress.com/bbs/read.php?tid=514111
        /// </summary>
        public Nullable<long> UndeliverableDecision { get; set; }

        /// <summary>
        /// ”根据订单号获取线上发货物流方案“API获取用户选择的实际发货物流服务（物流服务key,即仓库服务名称)例如：HRB_WLB_ZTOGZ是 中俄航空 Ruston广州仓库； HRB_WLB_RUSTONHEB为哈尔滨备货仓暂不支持，该渠道请做忽略。
        /// </summary>
        public string WarehouseCarrierService { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.logistics.createwarehouseorder";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("address_d_t_os", this.AddressDTOs);
            parameters.Add("declare_product_d_t_os", this.DeclareProductDTOs);
            parameters.Add("domestic_logistics_company", this.DomesticLogisticsCompany);
            parameters.Add("domestic_logistics_company_id", this.DomesticLogisticsCompanyId);
            parameters.Add("domestic_tracking_no", this.DomesticTrackingNo);
            parameters.Add("invoice_number", this.InvoiceNumber);
            parameters.Add("package_num", this.PackageNum);
            parameters.Add("top_user_key", this.TopUserKey);
            parameters.Add("trade_order_from", this.TradeOrderFrom);
            parameters.Add("trade_order_id", this.TradeOrderId);
            parameters.Add("undeliverable_decision", this.UndeliverableDecision);
            parameters.Add("warehouse_carrier_service", this.WarehouseCarrierService);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("address_d_t_os", this.AddressDTOs);
            RequestValidator.ValidateRequired("declare_product_d_t_os", this.DeclareProductDTOs);
            RequestValidator.ValidateObjectMaxListSize("declare_product_d_t_os", this.DeclareProductDTOs, 50);
            RequestValidator.ValidateRequired("domestic_logistics_company_id", this.DomesticLogisticsCompanyId);
            RequestValidator.ValidateRequired("domestic_tracking_no", this.DomesticTrackingNo);
            RequestValidator.ValidateMaxLength("top_user_key", this.TopUserKey, 16);
            RequestValidator.ValidateRequired("trade_order_from", this.TradeOrderFrom);
            RequestValidator.ValidateRequired("trade_order_id", this.TradeOrderId);
            RequestValidator.ValidateRequired("warehouse_carrier_service", this.WarehouseCarrierService);
        }

	/// <summary>
/// AeopWlDeclareAddressDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeopWlDeclareAddressDtoDomain : TopObject
{
	        /// <summary>
	        /// 卖家后台地址id,用来获取卖家详细地址信息，传入值为Long型；传入addressId后，其余字段值无效。
	        /// </summary>
	        [XmlElement("address_id")]
	        public Nullable<long> AddressId { get; set; }
	
	        /// <summary>
	        /// 城市
	        /// </summary>
	        [XmlElement("city")]
	        public string City { get; set; }
	
	        /// <summary>
	        /// 国家
	        /// </summary>
	        [XmlElement("country")]
	        public string Country { get; set; }
	
	        /// <summary>
	        /// 区
	        /// </summary>
	        [XmlElement("county")]
	        public string County { get; set; }
	
	        /// <summary>
	        /// 邮箱
	        /// </summary>
	        [XmlElement("email")]
	        public string Email { get; set; }
	
	        /// <summary>
	        /// 传真
	        /// </summary>
	        [XmlElement("fax")]
	        public string Fax { get; set; }
	
	        /// <summary>
	        /// 类型
	        /// </summary>
	        [XmlElement("member_type")]
	        public string MemberType { get; set; }
	
	        /// <summary>
	        /// 电话
	        /// </summary>
	        [XmlElement("mobile")]
	        public string Mobile { get; set; }
	
	        /// <summary>
	        /// 姓名
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 电话
	        /// </summary>
	        [XmlElement("phone")]
	        public string Phone { get; set; }
	
	        /// <summary>
	        /// 邮编
	        /// </summary>
	        [XmlElement("post_code")]
	        public string PostCode { get; set; }
	
	        /// <summary>
	        /// 省份
	        /// </summary>
	        [XmlElement("province")]
	        public string Province { get; set; }
	
	        /// <summary>
	        /// 街道
	        /// </summary>
	        [XmlElement("street")]
	        public string Street { get; set; }
	
	        /// <summary>
	        /// 详细地址
	        /// </summary>
	        [XmlElement("street_address")]
	        public string StreetAddress { get; set; }
	
	        /// <summary>
	        /// 旺旺
	        /// </summary>
	        [XmlElement("trademanage_id")]
	        public string TrademanageId { get; set; }
}

	/// <summary>
/// AddressdtosDomain Data Structure.
/// </summary>
[Serializable]

public class AddressdtosDomain : TopObject
{
	        /// <summary>
	        /// pickup address
	        /// </summary>
	        [XmlElement("pickup")]
	        public AeopWlDeclareAddressDtoDomain Pickup { get; set; }
	
	        /// <summary>
	        /// receiver address
	        /// </summary>
	        [XmlElement("receiver")]
	        public AeopWlDeclareAddressDtoDomain Receiver { get; set; }
	
	        /// <summary>
	        /// refund address
	        /// </summary>
	        [XmlElement("refund")]
	        public AeopWlDeclareAddressDtoDomain Refund { get; set; }
	
	        /// <summary>
	        /// sender address
	        /// </summary>
	        [XmlElement("sender")]
	        public AeopWlDeclareAddressDtoDomain Sender { get; set; }
}

	/// <summary>
/// AeopWlDeclareProductForTopDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AeopWlDeclareProductForTopDtoDomain : TopObject
{
	        /// <summary>
	        /// 判断是否属于非液体化妆品
	        /// </summary>
	        [XmlElement("aneroid_markup")]
	        public Nullable<bool> AneroidMarkup { get; set; }
	
	        /// <summary>
	        /// 是否易碎
	        /// </summary>
	        [XmlElement("breakable")]
	        public Nullable<bool> Breakable { get; set; }
	
	        /// <summary>
	        /// 类目中文名称
	        /// </summary>
	        [XmlElement("category_cn_desc")]
	        public string CategoryCnDesc { get; set; }
	
	        /// <summary>
	        /// 类目英文名称
	        /// </summary>
	        [XmlElement("category_en_desc")]
	        public string CategoryEnDesc { get; set; }
	
	        /// <summary>
	        /// 是否包含电池
	        /// </summary>
	        [XmlElement("contains_battery")]
	        public Nullable<bool> ContainsBattery { get; set; }
	
	        /// <summary>
	        /// 海关编码
	        /// </summary>
	        [XmlElement("hs_code")]
	        public string HsCode { get; set; }
	
	        /// <summary>
	        /// 是否纯电池
	        /// </summary>
	        [XmlElement("only_battery")]
	        public Nullable<bool> OnlyBattery { get; set; }
	
	        /// <summary>
	        /// 产品申报金额
	        /// </summary>
	        [XmlElement("product_declare_amount")]
	        public string ProductDeclareAmount { get; set; }
	
	        /// <summary>
	        /// 商品ID
	        /// </summary>
	        [XmlElement("product_id")]
	        public Nullable<long> ProductId { get; set; }
	
	        /// <summary>
	        /// 产品数量
	        /// </summary>
	        [XmlElement("product_num")]
	        public Nullable<long> ProductNum { get; set; }
	
	        /// <summary>
	        /// 产品重量
	        /// </summary>
	        [XmlElement("product_weight")]
	        public string ProductWeight { get; set; }
	
	        /// <summary>
	        /// scItem code
	        /// </summary>
	        [XmlElement("sc_item_code")]
	        public string ScItemCode { get; set; }
	
	        /// <summary>
	        /// scItem id
	        /// </summary>
	        [XmlElement("sc_item_id")]
	        public Nullable<long> ScItemId { get; set; }
	
	        /// <summary>
	        /// scItem name
	        /// </summary>
	        [XmlElement("sc_item_name")]
	        public string ScItemName { get; set; }
	
	        /// <summary>
	        /// sku code
	        /// </summary>
	        [XmlElement("sku_code")]
	        public string SkuCode { get; set; }
	
	        /// <summary>
	        /// sku value
	        /// </summary>
	        [XmlElement("sku_value")]
	        public string SkuValue { get; set; }
}

        #endregion
    }
}
