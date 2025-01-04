namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The shipping address for the order.
	/// </summary>
	public class OrderAddress : BaseClass
	{
		/// <summary>
		/// An Amazon-defined order identifier, in 3-7-7 format.
		/// </summary>
		[JsonProperty("AmazonOrderId")]
		[IsRequired]
		public string AmazonOrderId { get; set; }

		/// <summary>
		/// The company name of the contact buyer. For IBA orders, the buyer company must be Amazon entities.
		/// </summary>
		[JsonProperty("BuyerCompanyName")]
		public string BuyerCompanyName { get; set; }

		/// <summary>
		/// The shipping address for the order.  **Note**: `ShippingAddress` is only available for orders with the
		/// following status values: `Unshipped`, `PartiallyShipped`, `Shipped`, and `InvoiceUnconfirmed`.
		/// </summary>
		[JsonProperty("ShippingAddress")]
		public Address ShippingAddress { get; set; }

		[JsonProperty("DeliveryPreferences")]
		public DeliveryPreferences DeliveryPreferences { get; set; }
	}
}
