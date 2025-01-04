namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Details of the shipment label.
	/// </summary>
	public class LabelData : BaseClass
	{
		/// <summary>
		/// Identifier for the package. The first package will be 001, the second 002, and so on. This number is
		/// used as a reference to refer to this package from the pallet level.
		/// </summary>
		[JsonProperty("packageIdentifier")]
		public string PackageIdentifier { get; set; }

		/// <summary>
		/// Package tracking identifier from the shipping carrier.
		/// </summary>
		[JsonProperty("trackingNumber")]
		public string TrackingNumber { get; set; }

		/// <summary>
		/// Ship method to be used for shipping the order. Amazon defines Ship Method Codes indicating shipping carrier
		/// and shipment service level. Ship Method Codes are case and format sensitive. The same ship method code
		/// should returned on the shipment confirmation. Note that the Ship Method Codes are vendor specific and
		/// will be provided to each vendor during the implementation.
		/// </summary>
		[JsonProperty("shipMethod")]
		public string ShipMethod { get; set; }

		/// <summary>
		/// Shipping method name for internal reference.
		/// </summary>
		[JsonProperty("shipMethodName")]
		public string ShipMethodName { get; set; }

		/// <summary>
		/// This field will contain the Base64encoded string of the shipment label content.
		/// </summary>
		[JsonProperty("content")]
		[IsRequired]
		public string Content { get; set; }
	}
}
