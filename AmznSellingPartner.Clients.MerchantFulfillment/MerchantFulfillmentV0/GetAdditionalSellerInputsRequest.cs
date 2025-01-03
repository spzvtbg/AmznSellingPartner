namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Request schema
	/// </summary>
	public class GetAdditionalSellerInputsRequest : BaseClass
	{
		[IsRequired]
		[JsonProperty("ShippingServiceId")]
		public ShippingServiceIdentifier ShippingServiceId { get; set; }

		/// <summary>
		/// The address from which to ship
		/// </summary>
		[IsRequired]
		[JsonProperty("ShipFromAddress")]
		public Address ShipFromAddress { get; set; }

		/// <summary>
		/// An Amazon defined order identifier
		/// </summary>
		[IsRequired]
		[JsonProperty("OrderId")]
		public AmazonOrderId OrderId { get; set; }
	}
}
