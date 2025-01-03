namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The details of a shipment. Includes the shipment status.
	/// </summary>
	public class Shipment : BaseClass
	{
		[IsRequired]
		[JsonProperty("ShipmentId")]
		public ShipmentId ShipmentId { get; set; }

		[IsRequired]
		[JsonProperty("AmazonOrderId")]
		public AmazonOrderId AmazonOrderId { get; set; }

		[JsonProperty("SellerOrderId")]
		public SellerOrderId SellerOrderId { get; set; }

		[IsRequired]
		[JsonProperty("ItemList")]
		public ItemList ItemList { get; set; }

		/// <summary>
		/// The address of the sender.
		/// </summary>
		[IsRequired]
		[JsonProperty("ShipFromAddress")]
		public Address ShipFromAddress { get; set; }

		/// <summary>
		/// The destination address for the shipment.
		/// </summary>
		[IsRequired]
		[JsonProperty("ShipToAddress")]
		public Address ShipToAddress { get; set; }

		[IsRequired]
		[JsonProperty("PackageDimensions")]
		public PackageDimensions PackageDimensions { get; set; }

		/// <summary>
		/// The package weight.
		/// </summary>
		[IsRequired]
		[JsonProperty("Weight")]
		public Weight Weight { get; set; }

		/// <summary>
		/// If you specify `DeclaredValue` in a previous call to the `createShipment` operation, then `Insurance` indicate
		/// the shipment insurance amount that the carrier uses. If `DeclaredValue` isn't with a previous call to the `cr
		/// ateShipment` operation, then the shipment is insured for the carrier's minimum insurance amount, or the combin
		/// d sale prices that the items are listed for in the shipment.
		/// </summary>
		[IsRequired]
		[JsonProperty("Insurance")]
		public CurrencyAmount Insurance { get; set; }

		[IsRequired]
		[JsonProperty("ShippingService")]
		public ShippingService ShippingService { get; set; }

		/// <summary>
		/// Data for creating a shipping label and dimensions for printing the label. If the shipment is canceled, an empt
		/// label is returned.
		/// </summary>
		[IsRequired]
		[JsonProperty("Label")]
		public Label Label { get; set; }

		/// <summary>
		/// The shipment status.
		/// </summary>
		[IsRequired]
		[JsonProperty("Status")]
		public ShipmentStatus Status { get; set; }

		[JsonProperty("TrackingId")]
		public TrackingId TrackingId { get; set; }

		/// <summary>
		/// The date and time the shipment is created.
		/// </summary>
		[IsRequired]
		[JsonProperty("CreatedDate")]
		public Timestamp CreatedDate { get; set; }

		/// <summary>
		/// The date and time of the last update.
		/// </summary>
		[JsonProperty("LastUpdatedDate")]
		public Timestamp LastUpdatedDate { get; set; }
	}
}
