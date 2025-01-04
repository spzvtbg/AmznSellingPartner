namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// An amount of money, including units in the form of currency.
	/// </summary>
	public class Money : BaseClass
	{
		/// <summary>
		/// Three digit currency code in ISO 4217 format.
		/// </summary>
		[JsonProperty("currencyCode")]
		[IsRequired]
		public string CurrencyCode { get; set; } 

		[JsonProperty("value")]
		[IsRequired]
		public Decimal Value { get; set; } 
	}
}
