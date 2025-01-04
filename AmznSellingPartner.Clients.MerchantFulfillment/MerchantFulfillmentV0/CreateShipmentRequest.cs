namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Request schema.
	/// </summary>
	public class CreateShipmentRequest : BaseClass
	{
		/// <summary>
		/// Shipment information required to create a shipment.
		/// </summary>
		[JsonProperty("ShipmentRequestDetails")]
		[IsRequired]
		public ShipmentRequestDetails ShipmentRequestDetails { get; set; } 

		[JsonProperty("ShippingServiceId")]
		[IsRequired]
		public ShippingServiceIdentifier ShippingServiceId { get; set; } 

		/// <summary>
		/// Identifies a shipping service order made by a carrier.
		/// </summary>
		[JsonProperty("ShippingServiceOfferId")]
		public string ShippingServiceOfferId { get; set; } 

		/// <summary>
		/// Hazardous materials options for a package. Consult the terms and conditions for each carrier for more
		/// information about hazardous materials.
		/// </summary>
		[JsonProperty("HazmatType")]
		public HazmatType HazmatType { get; set; } 

		[JsonProperty("LabelFormatOption")]
		public LabelFormatOptionRequest LabelFormatOption { get; set; } 

		/// <summary>
		/// A list of additional seller inputs required to ship this shipment.
		/// </summary>
		[JsonProperty("ShipmentLevelSellerInputsList")]
		public AdditionalSellerInputsList ShipmentLevelSellerInputsList { get; set; } 
	}
}
