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
		[JsonProperty("CurrencyCode")]
		[IsRequired]
		[MaxLength(3)]
		public string CurrencyCode { get; set; } 

		/// <summary>
		/// The currency amount.
		/// </summary>
		[JsonProperty("Amount")]
		[IsRequired]
		public double Amount { get; set; } 
	}
}
