namespace AmznSellingPartner.Clients.ShipmentInvoicing.ShipmentInvoicingV0
{
	using Newtonsoft.Json;

	/// <summary>
	/// The currency type and amount.
	/// </summary>
	public class Money : BaseClass
	{
		/// <summary>
		/// Three-digit currency code in ISO 4217 format.
		/// </summary>
		[JsonProperty("CurrencyCode")]
		public string CurrencyCode { get; set; } 

		/// <summary>
		/// The currency amount.
		/// </summary>
		[JsonProperty("Amount")]
		public string Amount { get; set; } 
	}
}
