namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Information about a sub-payment method used to pay for a COD order.
	/// </summary>
	public class PaymentExecutionDetailItem : BaseClass
	{
		[JsonProperty("Payment")]
		[IsRequired]
		public Money Payment { get; set; } 

		/// <summary>
		/// A sub-payment method for a COD order.  **Possible values**: * `COD`: Cash on delivery  * `GC`:
		/// Gift card  * `PointsAccount`: Amazon Points * `Invoice`: Invoice
		/// </summary>
		[JsonProperty("PaymentMethod")]
		[IsRequired]
		public string PaymentMethod { get; set; } 
	}
}
