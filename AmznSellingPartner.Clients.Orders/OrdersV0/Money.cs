namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using Newtonsoft.Json;

	/// <summary>
	/// The monetary value of the order
	/// </summary>
	public class Money : BaseClass
	{
		/// <summary>
		/// The three-digit currency code
		/// In ISO 4217 format
		/// </summary>
		[JsonProperty("CurrencyCode")]
		public string CurrencyCode { get; set; }

		/// <summary>
		/// The currency amount
		/// </summary>
		[JsonProperty("Amount")]
		public string Amount { get; set; }
	}
}
