namespace AmznSellingPartner.Clients.VendorOrders.VendorOrders
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// An amount of money. Includes the currency code and an optional unit of measure for items priced
	/// by weight.
	/// </summary>
	public class Money : BaseClass
	{
		/// <summary>
		/// Three digit currency code in ISO 4217 format. String of length 3.
		/// </summary>
		[JsonProperty("currencyCode")]
		[MaxLength(3)]
		public string CurrencyCode { get; set; } 

		[JsonProperty("amount")]
		public Decimal Amount { get; set; } 

		/// <summary>
		/// The unit of measure for prices of items sold by weight. If this field is absent, the item is
		/// sold by eaches.
		/// </summary>
		[JsonProperty("unitOfMeasure")]
		public UnitOfMeasure UnitOfMeasure { get; set; } 
	}
}
