namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    /// <summary>
    /// Unique ID for the rateItem.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RateItemID
    {
        /// <summary>
        /// for Base Rate.
        /// </summary>
        [EnumMember(Value = "BASE_RATE")]
        BASE_RATE,

        /// <summary>
        /// Charge for TransAction Fee.
        /// </summary>
        [EnumMember(Value = "TRANSACTION_FEE")]
        TRANSACTION_FEE,

        /// <summary>
        /// Charge for Adult Signature Confirmation.
        /// </summary>
        [EnumMember(Value = "ADULT_SIGNATURE_CONFIRMATION")]
        ADULT_SIGNATURE_CONFIRMATION,

        /// <summary>
        /// Charge for signature confirmation.
        /// </summary>
        [EnumMember(Value = "SIGNATURE_CONFIRMATION")]
        SIGNATURE_CONFIRMATION,

        /// <summary>
        /// Charge for No Confirmation.
        /// </summary>
        [EnumMember(Value = "NO_CONFIRMATION")]
        NO_CONFIRMATION,

        /// <summary>
        /// Charge for Waive Signature.
        /// </summary>
        [EnumMember(Value = "WAIVE_SIGNATURE")]
        WAIVE_SIGNATURE,

        /// <summary>
        /// Charge for Implied Liability.
        /// </summary>
        [EnumMember(Value = "IMPLIED_LIABILITY")]
        IMPLIED_LIABILITY,

        /// <summary>
        /// Hidden Postage Charge.
        /// </summary>
        [EnumMember(Value = "HIDDEN_POSTAGE")]
        HIDDEN_POSTAGE,

        /// <summary>
        /// Declared Valure Coverage Charge.
        /// </summary>
        [EnumMember(Value = "DECLARED_VALUE")]
        DECLARED_VALUE,

        /// <summary>
        /// Sunday Holiday Delivery Charge.
        /// </summary>
        [EnumMember(Value = "SUNDAY_HOLIDAY_DELIVERY")]
        SUNDAY_HOLIDAY_DELIVERY,

        /// <summary>
        /// Charge for Delivery Confirmation.
        /// </summary>
        [EnumMember(Value = "DELIVERY_CONFIRMATION")]
        DELIVERY_CONFIRMATION,

        /// <summary>
        /// Import Duty Charge.
        /// </summary>
        [EnumMember(Value = "IMPORT_DUTY_CHARGE")]
        IMPORT_DUTY_CHARGE,

        /// <summary>
        /// Vat Charge.
        /// </summary>
        [EnumMember(Value = "VAT")]
        VAT,

        /// <summary>
        /// Charge for No Satuarday Delivery.
        /// </summary>
        [EnumMember(Value = "NO_SATURDAY_DELIVERY")]
        NO_SATURDAY_DELIVERY,

        /// <summary>
        /// Insurance Charge.
        /// </summary>
        [EnumMember(Value = "INSURANCE")]
        INSURANCE,

        /// <summary>
        /// COD Charge.
        /// </summary>
        [EnumMember(Value = "COD")]
        COD,

        /// <summary>
        /// Fuel Surcharge.
        /// </summary>
        [EnumMember(Value = "FUEL_SURCHARGE")]
        FUEL_SURCHARGE,

        /// <summary>
        /// Inspection Charge.
        /// </summary>
        [EnumMember(Value = "INSPECTION_CHARGE")]
        INSPECTION_CHARGE,

        /// <summary>
        /// Delivery Area Surcharge.
        /// </summary>
        [EnumMember(Value = "DELIVERY_AREA_SURCHARGE")]
        DELIVERY_AREA_SURCHARGE,

        /// <summary>
        /// WayBill Charge.
        /// </summary>
        [EnumMember(Value = "WAYBILL_CHARGE")]
        WAYBILL_CHARGE,

        /// <summary>
        /// Amazon Sponsored Discount.
        /// </summary>
        [EnumMember(Value = "AMAZON_SPONSORED_DISCOUNT")]
        AMAZON_SPONSORED_DISCOUNT,

        /// <summary>
        /// Integrator Sponsored Discount.
        /// </summary>
        [EnumMember(Value = "INTEGRATOR_SPONSORED_DISCOUNT")]
        INTEGRATOR_SPONSORED_DISCOUNT,

        /// <summary>
        /// OverSize Surcharge.
        /// </summary>
        [EnumMember(Value = "OVERSIZE_SURCHARGE")]
        OVERSIZE_SURCHARGE,

        /// <summary>
        /// Congestion Charge.
        /// </summary>
        [EnumMember(Value = "CONGESTION_CHARGE")]
        CONGESTION_CHARGE,

        /// <summary>
        /// Residential Surcharge.
        /// </summary>
        [EnumMember(Value = "RESIDENTIAL_SURCHARGE")]
        RESIDENTIAL_SURCHARGE,

        /// <summary>
        /// Additional Surcharge.
        /// </summary>
        [EnumMember(Value = "ADDITIONAL_SURCHARGE")]
        ADDITIONAL_SURCHARGE,

        /// <summary>
        /// Surcharge.
        /// </summary>
        [EnumMember(Value = "SURCHARGE")]
        SURCHARGE,

        /// <summary>
        /// Rebate.
        /// </summary>
        [EnumMember(Value = "REBATE")]
        REBATE,
    }
}
