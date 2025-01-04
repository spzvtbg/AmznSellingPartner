namespace AmznSellingPartner.Clients.ListingsItems.ListingsItems20210801
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The currency type and amount.
	/// </summary>
	public class Money : BaseClass
	{
		/// <summary>
		/// Three-digit currency code in ISO 4217 format.
		/// </summary>
		[JsonProperty("currencyCode")]
		[IsRequired]
		public string CurrencyCode { get; set; }

		/// <summary>
		/// The currency amount.
		/// </summary>
		[JsonProperty("amount")]
		[IsRequired]
		public Decimal Amount { get; set; }
	}
}
