namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
	using Newtonsoft.Json;

	/// <summary>
	/// Currency type and monetary value schema to demonstrate pricing information.
	/// </summary>
	public class MoneyType : BaseClass
	{
		/// <summary>
		/// The currency code in ISO 4217 format.
		/// </summary>
		[JsonProperty("currencyCode")]
		public string CurrencyCode { get; set; } 

		/// <summary>
		/// The monetary value.
		/// </summary>
		[JsonProperty("amount")]
		public double Amount { get; set; } 
	}
}
