namespace AmznSellingPartner.Clients.ProductFees.ProductFeesV0
{
	using Newtonsoft.Json;

	public class MoneyType : BaseClass
	{
		/// <summary>
		/// The currency code in ISO 4217 format.
		/// </summary>
		[JsonProperty("CurrencyCode")]
		public string CurrencyCode { get; set; } 

		/// <summary>
		/// The monetary value.
		/// </summary>
		[JsonProperty("Amount")]
		public double Amount { get; set; } 
	}
}
