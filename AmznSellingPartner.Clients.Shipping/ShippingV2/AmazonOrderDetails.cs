namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Amazon order information. This is required if the shipment source channel is Amazon.
	/// </summary>
	public class AmazonOrderDetails : BaseClass
	{
		/// <summary>
		/// The Amazon order ID associated with the Amazon order fulfilled by this shipment.
		/// </summary>
		[JsonProperty("orderId")]
		[IsRequired]
		public string OrderId { get; set; } 
	}
}
