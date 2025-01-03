namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The request schema for the purchaseShipment operation
	/// </summary>
	public class PurchaseShipmentRequest : BaseClass
	{
		[IsRequired]
		[JsonProperty("requestToken")]
		public RequestToken RequestToken { get; set; }

		[IsRequired]
		[JsonProperty("rateId")]
		public RateId RateId { get; set; }

		[IsRequired]
		[JsonProperty("requestedDocumentSpecification")]
		public RequestedDocumentSpecification RequestedDocumentSpecification { get; set; }

		[JsonProperty("requestedValueAddedServices")]
		public RequestedValueAddedServiceList RequestedValueAddedServices { get; set; }

		/// <summary>
		/// The additional inputs required to purchase a shipping offering, in JSON format
		/// The JSON provided here must adhere to the JSON schema that is returned in the response to the getAdditionalIn
		/// uts operation
		/// Additional inputs are only required when indicated by the requiresAdditionalInputs property in the response
		/// o the getRates operation
		/// </summary>
		[JsonProperty("additionalInputs")]
		public AdditionalInputs AdditionalInputs { get; set; }
	}
}
