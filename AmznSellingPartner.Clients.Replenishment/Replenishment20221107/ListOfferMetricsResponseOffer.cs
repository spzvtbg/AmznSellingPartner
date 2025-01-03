namespace AmznSellingPartner.Clients.Replenishment.Replenishment20221107
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// An object which contains offer metrics.
	/// </summary>
	public class ListOfferMetricsResponseOffer : BaseClass
	{
		/// <summary>
		/// The Amazon Standard Identification Number (ASIN).
		/// </summary>
		[JsonProperty("asin")]
		public string Asin { get; set; }

		/// <summary>
		/// The percentage of items that were not shipped out of the total shipped units over a period of time due to bein
		/// out of stock. Applicable to PERFORMANCE timePeriodType.
		/// </summary>
		[Minimum(0)]
		[Maximum(100)]
		[JsonProperty("notDeliveredDueToOOS")]
		public double NotDeliveredDueToOOS { get; set; }

		/// <summary>
		/// The revenue generated from subscriptions over a period of time. Applicable to PERFORMANCE timePeriodType.
		/// </summary>
		[Minimum(0)]
		[JsonProperty("totalSubscriptionsRevenue")]
		public double TotalSubscriptionsRevenue { get; set; }

		/// <summary>
		/// The number of units shipped to the subscribers over a period of time. Applicable to PERFORMANCE timePeriodType
		/// 
		/// </summary>
		[Minimum(0)]
		[JsonProperty("shippedSubscriptionUnits")]
		public long ShippedSubscriptionUnits { get; set; }

		/// <summary>
		/// The number of active subscriptions present at the end of the period. Applicable to PERFORMANCE timePeriodType.
		/// </summary>
		[Minimum(0)]
		[JsonProperty("activeSubscriptions")]
		public long ActiveSubscriptions { get; set; }

		/// <summary>
		/// The percentage of total program revenue out of total product revenue. Applicable to PERFORMANCE timePeriodType
		/// 
		/// </summary>
		[Minimum(0)]
		[Maximum(100)]
		[JsonProperty("revenuePenetration")]
		public double RevenuePenetration { get; set; }

		/// <summary>
		/// The revenue that would have been generated had there not been out of stock. Applicable to PERFORMANCE timePeri
		/// dType.
		/// </summary>
		[Minimum(0)]
		[JsonProperty("lostRevenueDueToOOS")]
		public double LostRevenueDueToOOS { get; set; }

		/// <summary>
		/// The percentage of revenue from ASINs with coupons out of total revenue from all ASINs. Applicable to PERFORMAN
		/// E timePeriodType.
		/// </summary>
		[Minimum(0)]
		[Maximum(100)]
		[JsonProperty("couponsRevenuePenetration")]
		public double CouponsRevenuePenetration { get; set; }

		/// <summary>
		/// The percentage of new subscriptions acquired through coupons. Applicable to PERFORMANCE timePeriodType.
		/// </summary>
		[Minimum(0)]
		[Maximum(100)]
		[JsonProperty("shareOfCouponSubscriptions")]
		public double ShareOfCouponSubscriptions { get; set; }

		/// <summary>
		/// The forecasted total subscription revenue for the next 30 days. Applicable to FORECAST timePeriodType.
		/// </summary>
		[Minimum(0)]
		[JsonProperty("next30DayTotalSubscriptionsRevenue")]
		public double Next30DayTotalSubscriptionsRevenue { get; set; }

		/// <summary>
		/// The forecasted total subscription revenue for the next 60 days. Applicable to FORECAST timePeriodType.
		/// </summary>
		[Minimum(0)]
		[JsonProperty("next60DayTotalSubscriptionsRevenue")]
		public double Next60DayTotalSubscriptionsRevenue { get; set; }

		/// <summary>
		/// The forecasted total subscription revenue for the next 90 days. Applicable to FORECAST timePeriodType.
		/// </summary>
		[Minimum(0)]
		[JsonProperty("next90DayTotalSubscriptionsRevenue")]
		public double Next90DayTotalSubscriptionsRevenue { get; set; }

		/// <summary>
		/// The forecasted shipped subscription units for the next 30 days. Applicable to FORECAST timePeriodType.
		/// </summary>
		[Minimum(0)]
		[JsonProperty("next30DayShippedSubscriptionUnits")]
		public long Next30DayShippedSubscriptionUnits { get; set; }

		/// <summary>
		/// The forecasted shipped subscription units for the next 60 days. Applicable to FORECAST timePeriodType.
		/// </summary>
		[Minimum(0)]
		[JsonProperty("next60DayShippedSubscriptionUnits")]
		public long Next60DayShippedSubscriptionUnits { get; set; }

		/// <summary>
		/// The forecasted shipped subscription units for the next 90 days. Applicable to FORECAST timePeriodType.
		/// </summary>
		[Minimum(0)]
		[JsonProperty("next90DayShippedSubscriptionUnits")]
		public long Next90DayShippedSubscriptionUnits { get; set; }

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
