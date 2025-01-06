namespace AmznSellingPartner.Clients.ProductFees.ProductFeesV0
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	using Newtonsoft.Json;

	/// <summary>
	/// The total estimated fees for an item and a list of details.
	/// </summary>
	public class FeesEstimate : BaseClass
	{
		/// <summary>
		/// The time at which the fees were estimated. This defaults to the time the request is made.
		/// </summary>
		[JsonProperty("TimeOfFeesEstimation")]
		[IsRequired]
		public DateTimeValue TimeOfFeesEstimation { get; set; } 

		/// <summary>
		/// Total estimated fees for a given item, price, and fulfillment channel.
		/// </summary>
		[JsonProperty("TotalFeesEstimate")]
		public MoneyType TotalFeesEstimate { get; set; } 

		[JsonProperty("FeeDetailList")]
		public FeeDetailList FeeDetailList { get; set; } 
	}
}
