namespace AmznSellingPartner.Clients.VendorDirectFulfillmentOrders.VendorDirectFulfillmentOrders20211228
{
	using Newtonsoft.Json;

	/// <summary>
	/// An amount of money, including units in the form of currency.
	/// </summary>
	public class Money : BaseClass
	{
		/// <summary>
		/// Three digit currency code in ISO 4217 format. String of length 3.
		/// </summary>
		[JsonProperty("currencyCode")]
		public string CurrencyCode { get; set; }

		[JsonProperty("amount")]
		public Decimal Amount { get; set; }
	}
}
