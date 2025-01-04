namespace AmznSellingPartner.Clients.ProductFees.ProductFeesV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Price information for an item, used to estimate fees.
	/// </summary>
	public class PriceToEstimateFees : BaseClass
	{
		/// <summary>
		/// The price of the item.
		/// </summary>
		[JsonProperty("ListingPrice")]
		[IsRequired]
		public MoneyType ListingPrice { get; set; }

		/// <summary>
		/// The shipping cost.
		/// </summary>
		[JsonProperty("Shipping")]
		public MoneyType Shipping { get; set; }

		/// <summary>
		/// The number of Amazon Points offered with the purchase of an item.
		/// </summary>
		[JsonProperty("Points")]
		public Points Points { get; set; }
	}
}
