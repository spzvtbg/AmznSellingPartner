namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Currency type and amount.
	/// </summary>
	public class CurrencyAmount : BaseClass
	{
		/// <summary>
		/// Three-digit currency code in ISO 4217 format.
		/// </summary>
		[IsRequired]
		[MaxLength(3)]
		[JsonProperty("CurrencyCode")]
		public string CurrencyCode { get; set; }

		/// <summary>
		/// The currency amount.
		/// </summary>
		[IsRequired]
		[JsonProperty("Amount")]
		public double Amount { get; set; }
	}
}
