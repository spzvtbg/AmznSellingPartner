namespace AmznSellingPartner.Clients.Replenishment.Replenishment20221107
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// An object which contains metric data for a selling partner
	/// </summary>
	public class GetSellingPartnerMetricsResponseMetric : BaseClass
	{
		/// <summary>
		/// The percentage of items that were not shipped out of the total shipped units over a period of time due to bein
		/// out of stock
		/// Applicable to PERFORMANCE timePeriodType
		/// </summary>
		[Minimum(0)]
		[Maximum(100)]
		[JsonProperty("notDeliveredDueToOOS")]
		public double NotDeliveredDueToOOS { get; set; }

		/// <summary>
		/// The revenue generated from subscriptions over a period of time
		/// Applicable for both the PERFORMANCE and FORECAST timePeriodType
		/// </summary>
		[Minimum(0)]
		[JsonProperty("totalSubscriptionsRevenue")]
		public double TotalSubscriptionsRevenue { get; set; }

		/// <summary>
		/// The number of units shipped to the subscribers over a period of time
		/// Applicable for both the PERFORMANCE and FORECAST timePeriodType
		/// </summary>
		[Minimum(0)]
		[JsonProperty("shippedSubscriptionUnits")]
		public long ShippedSubscriptionUnits { get; set; }

		/// <summary>
		/// The number of active subscriptions present at the end of the period
		/// Applicable to PERFORMANCE timePeriodType
		/// </summary>
		[Minimum(0)]
		[JsonProperty("activeSubscriptions")]
		public long ActiveSubscriptions { get; set; }

		/// <summary>
		/// The average revenue per subscriber of the program over a period of past 12 months for sellers and 6 months for
		/// vendors
		/// Applicable to PERFORMANCE timePeriodType
		/// </summary>
		[Minimum(0)]
		[JsonProperty("subscriberAverageRevenue")]
		public double SubscriberAverageRevenue { get; set; }

		/// <summary>
		/// The average revenue per non-subscriber of the program over a period of past 12 months for sellers and 6 months
		/// for vendors
		/// Applicable to PERFORMANCE timePeriodType
		/// </summary>
		[Minimum(0)]
		[JsonProperty("nonSubscriberAverageRevenue")]
		public double NonSubscriberAverageRevenue { get; set; }

		/// <summary>
		/// The revenue that would have been generated had there not been out of stock
		/// Applicable to PERFORMANCE timePeriodType
		/// </summary>
		[Minimum(0)]
		[JsonProperty("lostRevenueDueToOOS")]
		public double LostRevenueDueToOOS { get; set; }

		/// <summary>
		/// The average reorders per subscriber of the program over a period of 12 months
		/// Applicable to PERFORMANCE timePeriodType
		/// </summary>
		[Minimum(0)]
		[JsonProperty("subscriberAverageReorders")]
		public double SubscriberAverageReorders { get; set; }

		/// <summary>
		/// The average reorders per non-subscriber of the program over a period of past 12 months
		/// Applicable to PERFORMANCE timePeriodType
		/// </summary>
		[Minimum(0)]
		[JsonProperty("nonSubscriberAverageReorders")]
		public double NonSubscriberAverageReorders { get; set; }

		/// <summary>
		/// The percentage of revenue from ASINs with coupons out of total revenue from all ASINs
		/// Applicable to PERFORMANCE timePeriodType
		/// </summary>
		[Minimum(0)]
		[Maximum(100)]
		[JsonProperty("couponsRevenuePenetration")]
		public double CouponsRevenuePenetration { get; set; }

		/// <summary>
		/// The subscription revenue generated from subscriptions with over two deliveries over the past 12 months
		/// Applicable to PERFORMANCE timePeriodType
		/// </summary>
		[Minimum(0)]
		[JsonProperty("revenueFromSubscriptionsWithMultipleDeliveries")]
		public double RevenueFromSubscriptionsWithMultipleDeliveries { get; set; }

		/// <summary>
		/// The subscription revenue generated from active subscriptions with one delivery over the past 12 months
		/// Applicable to PERFORMANCE timePeriodType
		/// </summary>
		[Minimum(0)]
		[JsonProperty("revenueFromActiveSubscriptionsWithSingleDelivery")]
		public double RevenueFromActiveSubscriptionsWithSingleDelivery { get; set; }

		/// <summary>
		/// The subscription revenue generated from subscriptions which are cancelled after one delivery over the past 12
		/// onths
		/// Applicable to PERFORMANCE timePeriodType
		/// </summary>
		[Minimum(0)]
		[JsonProperty("revenueFromCancelledSubscriptionsAfterSingleDelivery")]
		public double RevenueFromCancelledSubscriptionsAfterSingleDelivery { get; set; }

		/// <summary>
		/// The percentage of subscriptions retained after 30 days of subscription creation
		/// Applicable to PERFORMANCE timePeriodType
		/// </summary>
		[Minimum(0)]
		[Maximum(100)]
		[JsonProperty("subscriberRetentionFor30Days")]
		public double SubscriberRetentionFor30Days { get; set; }

		/// <summary>
		/// The percentage of subscriptions retained after 90 days of subscription creation
		/// Applicable to PERFORMANCE timePeriodType
		/// </summary>
		[Minimum(0)]
		[Maximum(100)]
		[JsonProperty("subscriberRetentionFor90Days")]
		public double SubscriberRetentionFor90Days { get; set; }

		/// <summary>
		/// The percentage of subscription revenue generated by offers with 0% seller-funded discount over the last 12 mon
		/// hs
		/// Applicable to PERFORMANCE timePeriodType
		/// </summary>
		[Minimum(0)]
		[Maximum(100)]
		[JsonProperty("revenuePenetrationFor0PercentSellerFunding")]
		public double RevenuePenetrationFor0PercentSellerFunding { get; set; }

		/// <summary>
		/// [Applicable only for Sellers] The percentage of subscription revenue generated by offers with 5% seller-funded
		/// discount over the last 12 months
		/// Applicable to PERFORMANCE timePeriodType
		/// </summary>
		[Minimum(0)]
		[Maximum(100)]
		[JsonProperty("revenuePenetrationFor5PercentSellerFunding")]
		public double RevenuePenetrationFor5PercentSellerFunding { get; set; }

		/// <summary>
		/// [Applicable only for Sellers] The percentage of subscription revenue generated by offers with 10% seller-funde
		/// discount over the last 12 months
		/// Applicable to PERFORMANCE timePeriodType
		/// </summary>
		[Minimum(0)]
		[Maximum(100)]
		[JsonProperty("revenuePenetrationFor10PercentSellerFunding")]
		public double RevenuePenetrationFor10PercentSellerFunding { get; set; }

		/// <summary>
		/// [Applicable only for vendors] The percentage of subscription revenue generated by offers with 5% or above sell
		/// r-funded discount over the last 12 months
		/// Applicable to PERFORMANCE timePeriodType
		/// </summary>
		[Minimum(0)]
		[Maximum(100)]
		[JsonProperty("revenuePenetrationFor5PlusPercentSellerFunding")]
		public double RevenuePenetrationFor5PlusPercentSellerFunding { get; set; }

		/// <summary>
		/// The percentage of new subscriptions acquired through coupons
		/// Applicable to PERFORMANCE timePeriodType
		/// </summary>
		[Minimum(0)]
		[Maximum(100)]
		[JsonProperty("shareOfCouponSubscriptions")]
		public double ShareOfCouponSubscriptions { get; set; }

		/// <summary>
		/// A time interval used to compute metrics
		/// </summary>
		[JsonProperty("timeInterval")]
		public TimeInterval TimeInterval { get; set; }

		/// <summary>
		/// The currency code in ISO 4217 format
		/// </summary>
		[JsonProperty("currencyCode")]
		public string CurrencyCode { get; set; }
	}
}
