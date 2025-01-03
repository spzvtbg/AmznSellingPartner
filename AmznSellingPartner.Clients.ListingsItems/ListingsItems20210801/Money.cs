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
		[IsRequired]
		[JsonProperty("currencyCode")]
		public string CurrencyCode { get; set; }

		/// <summary>
		/// The currency amount.
		/// </summary>
		[IsRequired]
		[JsonProperty("amount")]
		public Decimal Amount { get; set; }
	}
}
