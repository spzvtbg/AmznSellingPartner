namespace AmznSellingPartner.Clients.Replenishment.Replenishment20221107
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// An object which contains metric data for a selling partner.
    /// </summary>
    public class GetSellingPartnerMetricsResponseMetric : BaseClass
    {
        /// <summary>
        /// The percentage of items that were not shipped out of the total shipped units over a period
        /// of time due to being out of stock. Applicable to PERFORMANCE timePeriodType.
        /// </summary>
        [JsonProperty("notDeliveredDueToOOS")]
        [Minimum(0)]
        [Maximum(100)]
        public double NotDeliveredDueToOOS { get; set; }

        /// <summary>
        /// The revenue generated from subscriptions over a period of time. Applicable for both the PERFORMANCE
        /// and FORECAST timePeriodType.
        /// </summary>
        [JsonProperty("totalSubscriptionsRevenue")]
        [Minimum(0)]
        public double TotalSubscriptionsRevenue { get; set; }

        /// <summary>
        /// The number of units shipped to the subscribers over a period of time. Applicable for both the
        /// PERFORMANCE and FORECAST timePeriodType.
        /// </summary>
        [JsonProperty("shippedSubscriptionUnits")]
        [Minimum(0)]
        public long ShippedSubscriptionUnits { get; set; }

        /// <summary>
        /// The number of active subscriptions present at the end of the period. Applicable to PERFORMANCE
        /// timePeriodType.
        /// </summary>
        [JsonProperty("activeSubscriptions")]
        [Minimum(0)]
        public long ActiveSubscriptions { get; set; }

        /// <summary>
        /// The average revenue per subscriber of the program over a period of past 12 months for sellers
        /// and 6 months for vendors. Applicable to PERFORMANCE timePeriodType.
        /// </summary>
        [JsonProperty("subscriberAverageRevenue")]
        [Minimum(0)]
        public double SubscriberAverageRevenue { get; set; }

        /// <summary>
        /// The average revenue per non-subscriber of the program over a period of past 12 months for sellers
        /// and 6 months for vendors. Applicable to PERFORMANCE timePeriodType.
        /// </summary>
        [JsonProperty("nonSubscriberAverageRevenue")]
        [Minimum(0)]
        public double NonSubscriberAverageRevenue { get; set; }

        /// <summary>
        /// The revenue that would have been generated had there not been out of stock. Applicable to PERFORMANCE
        /// timePeriodType.
        /// </summary>
        [JsonProperty("lostRevenueDueToOOS")]
        [Minimum(0)]
        public double LostRevenueDueToOOS { get; set; }

        /// <summary>
        /// The average reorders per subscriber of the program over a period of 12 months. Applicable to
        /// PERFORMANCE timePeriodType.
        /// </summary>
        [JsonProperty("subscriberAverageReorders")]
        [Minimum(0)]
        public double SubscriberAverageReorders { get; set; }

        /// <summary>
        /// The average reorders per non-subscriber of the program over a period of past 12 months. Applicable
        /// to PERFORMANCE timePeriodType.
        /// </summary>
        [JsonProperty("nonSubscriberAverageReorders")]
        [Minimum(0)]
        public double NonSubscriberAverageReorders { get; set; }

        /// <summary>
        /// The percentage of revenue from ASINs with coupons out of total revenue from all ASINs. Applicable
        /// to PERFORMANCE timePeriodType.
        /// </summary>
        [JsonProperty("couponsRevenuePenetration")]
        [Minimum(0)]
        [Maximum(100)]
        public double CouponsRevenuePenetration { get; set; }

        /// <summary>
        /// The subscription revenue generated from subscriptions with over two deliveries over the past
        /// 12 months. Applicable to PERFORMANCE timePeriodType.
        /// </summary>
        [JsonProperty("revenueFromSubscriptionsWithMultipleDeliveries")]
        [Minimum(0)]
        public double RevenueFromSubscriptionsWithMultipleDeliveries { get; set; }

        /// <summary>
        /// The subscription revenue generated from active subscriptions with one delivery over the past
        /// 12 months. Applicable to PERFORMANCE timePeriodType.
        /// </summary>
        [JsonProperty("revenueFromActiveSubscriptionsWithSingleDelivery")]
        [Minimum(0)]
        public double RevenueFromActiveSubscriptionsWithSingleDelivery { get; set; }

        /// <summary>
        /// The subscription revenue generated from subscriptions which are cancelled after one delivery
        /// over the past 12 months. Applicable to PERFORMANCE timePeriodType.
        /// </summary>
        [JsonProperty("revenueFromCancelledSubscriptionsAfterSingleDelivery")]
        [Minimum(0)]
        public double RevenueFromCancelledSubscriptionsAfterSingleDelivery { get; set; }

        /// <summary>
        /// The percentage of subscriptions retained after 30 days of subscription creation. Applicable
        /// to PERFORMANCE timePeriodType.
        /// </summary>
        [JsonProperty("subscriberRetentionFor30Days")]
        [Minimum(0)]
        [Maximum(100)]
        public double SubscriberRetentionFor30Days { get; set; }

        /// <summary>
        /// The percentage of subscriptions retained after 90 days of subscription creation. Applicable
        /// to PERFORMANCE timePeriodType.
        /// </summary>
        [JsonProperty("subscriberRetentionFor90Days")]
        [Minimum(0)]
        [Maximum(100)]
        public double SubscriberRetentionFor90Days { get; set; }

        /// <summary>
        /// The percentage of subscription revenue generated by offers with 0% seller-funded discount over
        /// the last 12 months. Applicable to PERFORMANCE timePeriodType.
        /// </summary>
        [JsonProperty("revenuePenetrationFor0PercentSellerFunding")]
        [Minimum(0)]
        [Maximum(100)]
        public double RevenuePenetrationFor0PercentSellerFunding { get; set; }

        /// <summary>
        /// [Applicable only for Sellers] The percentage of subscription revenue generated by offers with
        /// 5% seller-funded discount over the last 12 months. Applicable to PERFORMANCE timePeriodTyp
        /// e.
        /// </summary>
        [JsonProperty("revenuePenetrationFor5PercentSellerFunding")]
        [Minimum(0)]
        [Maximum(100)]
        public double RevenuePenetrationFor5PercentSellerFunding { get; set; }

        /// <summary>
        /// [Applicable only for Sellers] The percentage of subscription revenue generated by offers with
        /// 10% seller-funded discount over the last 12 months. Applicable to PERFORMANCE timePeriodTy
        /// pe.
        /// </summary>
        [JsonProperty("revenuePenetrationFor10PercentSellerFunding")]
        [Minimum(0)]
        [Maximum(100)]
        public double RevenuePenetrationFor10PercentSellerFunding { get; set; }

        /// <summary>
        /// [Applicable only for vendors] The percentage of subscription revenue generated by offers with
        /// 5% or above seller-funded discount over the last 12 months. Applicable to PERFORMANCE time
        /// PeriodType.
        /// </summary>
        [JsonProperty("revenuePenetrationFor5PlusPercentSellerFunding")]
        [Minimum(0)]
        [Maximum(100)]
        public double RevenuePenetrationFor5PlusPercentSellerFunding { get; set; }

        /// <summary>
        /// The percentage of new subscriptions acquired through coupons. Applicable to PERFORMANCE ti
        /// mePeriodType.
        /// </summary>
        [JsonProperty("shareOfCouponSubscriptions")]
        [Minimum(0)]
        [Maximum(100)]
        public double ShareOfCouponSubscriptions { get; set; }

        /// <summary>
        /// A time interval used to compute metrics.
        /// </summary>
        [JsonProperty("timeInterval")]
        public TimeInterval TimeInterval { get; set; }

        /// <summary>
        /// The currency code in ISO 4217 format.
        /// </summary>
        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }
    }
}
