namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// A shipping service offer made by a carrier.
	/// </summary>
	public class ShippingService : BaseClass
	{
		/// <summary>
		/// A plain text representation of a carrier's shipping service. For example, "UPS Ground" or "FedEx Standard Over
		/// ight".
		/// </summary>
		[IsRequired]
		[JsonProperty("ShippingServiceName")]
		public string ShippingServiceName { get; set; }

		/// <summary>
		/// The name of the carrier.
		/// </summary>
		[IsRequired]
		[JsonProperty("CarrierName")]
		public string CarrierName { get; set; }

		[IsRequired]
		[JsonProperty("ShippingServiceId")]
		public ShippingServiceIdentifier ShippingServiceId { get; set; }

		/// <summary>
		/// An Amazon-defined shipping service offer identifier.
		/// </summary>
		[IsRequired]
		[JsonProperty("ShippingServiceOfferId")]
		public string ShippingServiceOfferId { get; set; }

		/// <summary>
		/// The date that the carrier will ship the package.
		/// </summary>
		[IsRequired]
		[JsonProperty("ShipDate")]
		public Timestamp ShipDate { get; set; }

		/// <summary>
		/// The earliest date by which the shipment will be delivered.
		/// </summary>
		[JsonProperty("EarliestEstimatedDeliveryDate")]
		public Timestamp EarliestEstimatedDeliveryDate { get; set; }

		/// <summary>
		/// The latest date by which the shipment will be delivered.
		/// </summary>
		[JsonProperty("LatestEstimatedDeliveryDate")]
		public Timestamp LatestEstimatedDeliveryDate { get; set; }

		/// <summary>
		/// The amount that the carrier will charge for the shipment.
		/// </summary>
		[IsRequired]
		[JsonProperty("Rate")]
		public CurrencyAmount Rate { get; set; }

		/// <summary>
		/// Extra services offered by the carrier.
		/// </summary>
		[IsRequired]
		[JsonProperty("ShippingServiceOptions")]
		public ShippingServiceOptions ShippingServiceOptions { get; set; }

		[JsonProperty("AvailableShippingServiceOptions")]
		public AvailableShippingServiceOptions AvailableShippingServiceOptions { get; set; }

		[JsonProperty("AvailableLabelFormats")]
		public LabelFormatList AvailableLabelFormats { get; set; }

		[JsonProperty("AvailableFormatOptionsForLabel")]
		public AvailableFormatOptionsForLabelList AvailableFormatOptionsForLabel { get; set; }

		/// <summary>
		/// When true, additional seller inputs are required.
		/// </summary>
		[IsRequired]
		[JsonProperty("RequiresAdditionalSellerInputs")]
		public bool RequiresAdditionalSellerInputs { get; set; }

		[JsonProperty("Benefits")]
		public Benefits Benefits { get; set; }
	}
}
