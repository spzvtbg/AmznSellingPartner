namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The details of a shipping service offering
	/// </summary>
	public class Rate : BaseClass
	{
		[IsRequired]
		[JsonProperty("rateId")]
		public RateId RateId { get; set; }

		[IsRequired]
		[JsonProperty("carrierId")]
		public CarrierId CarrierId { get; set; }

		[IsRequired]
		[JsonProperty("carrierName")]
		public CarrierName CarrierName { get; set; }

		[IsRequired]
		[JsonProperty("serviceId")]
		public ServiceId ServiceId { get; set; }

		[IsRequired]
		[JsonProperty("serviceName")]
		public ServiceName ServiceName { get; set; }

		[JsonProperty("billedWeight")]
		public Weight BilledWeight { get; set; }

		[IsRequired]
		[JsonProperty("totalCharge")]
		public Currency TotalCharge { get; set; }

		[IsRequired]
		[JsonProperty("promise")]
		public Promise Promise { get; set; }

		[IsRequired]
		[JsonProperty("supportedDocumentSpecifications")]
		public SupportedDocumentSpecificationList SupportedDocumentSpecifications { get; set; }

		[JsonProperty("availableValueAddedServiceGroups")]
		public AvailableValueAddedServiceGroupList AvailableValueAddedServiceGroups { get; set; }

		/// <summary>
		/// When true, indicates that additional inputs are required to purchase this shipment service
		/// You must then call the getAdditionalInputs operation to return the JSON schema to use when providing the addi
		/// ional inputs to the purchaseShipment operation
		/// </summary>
		[IsRequired]
		[JsonProperty("requiresAdditionalInputs")]
		public bool RequiresAdditionalInputs { get; set; }

		[JsonProperty("rateItemList")]
		public RateItemList RateItemList { get; set; }

		[JsonProperty("paymentType")]
		public PaymentType PaymentType { get; set; }

		[JsonProperty("benefits")]
		public Benefits Benefits { get; set; }
	}
}
