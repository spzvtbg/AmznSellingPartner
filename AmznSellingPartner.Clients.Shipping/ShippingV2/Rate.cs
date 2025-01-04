namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The details of a shipping service offering.
	/// </summary>
	public class Rate : BaseClass
	{
		[JsonProperty("rateId")]
		[IsRequired]
		public RateId RateId { get; set; } 

		[JsonProperty("carrierId")]
		[IsRequired]
		public CarrierId CarrierId { get; set; } 

		[JsonProperty("carrierName")]
		[IsRequired]
		public CarrierName CarrierName { get; set; } 

		[JsonProperty("serviceId")]
		[IsRequired]
		public ServiceId ServiceId { get; set; } 

		[JsonProperty("serviceName")]
		[IsRequired]
		public ServiceName ServiceName { get; set; } 

		[JsonProperty("billedWeight")]
		public Weight BilledWeight { get; set; } 

		[JsonProperty("totalCharge")]
		[IsRequired]
		public Currency TotalCharge { get; set; } 

		[JsonProperty("promise")]
		[IsRequired]
		public Promise Promise { get; set; } 

		[JsonProperty("supportedDocumentSpecifications")]
		[IsRequired]
		public SupportedDocumentSpecificationList SupportedDocumentSpecifications { get; set; } 

		[JsonProperty("availableValueAddedServiceGroups")]
		public AvailableValueAddedServiceGroupList AvailableValueAddedServiceGroups { get; set; } 

		/// <summary>
		/// When true, indicates that additional inputs are required to purchase this shipment service. You must
		/// then call the getAdditionalInputs operation to return the JSON schema to use when providing the additional
		/// inputs to the purchaseShipment operation.
		/// </summary>
		[JsonProperty("requiresAdditionalInputs")]
		[IsRequired]
		public bool RequiresAdditionalInputs { get; set; } 

		[JsonProperty("rateItemList")]
		public RateItemList RateItemList { get; set; } 

		[JsonProperty("paymentType")]
		public PaymentType PaymentType { get; set; } 

		[JsonProperty("benefits")]
		public Benefits Benefits { get; set; } 
	}
}
