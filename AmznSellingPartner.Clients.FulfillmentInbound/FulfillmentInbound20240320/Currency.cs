namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The type and amount of currency
	/// </summary>
	public class Currency : BaseClass
	{
		/// <summary>
		/// Decimal value of the currency
		/// </summary>
		[IsRequired]
		[JsonProperty("amount")]
		public double Amount { get; set; }

		/// <summary>
		/// ISO 4217 standard of a currency code
		/// </summary>
		[IsRequired]
		[MinLength(3)]
		[MaxLength(3)]
		[JsonProperty("code")]
		public string Code { get; set; }
	}
}
