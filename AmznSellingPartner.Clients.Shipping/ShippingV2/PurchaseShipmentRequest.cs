namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The request schema for the purchaseShipment operation.
	/// </summary>
	public class PurchaseShipmentRequest : BaseClass
	{
		[JsonProperty("requestToken")]
		[IsRequired]
		public RequestToken RequestToken { get; set; } 

		[JsonProperty("rateId")]
		[IsRequired]
		public RateId RateId { get; set; } 

		[JsonProperty("requestedDocumentSpecification")]
		[IsRequired]
		public RequestedDocumentSpecification RequestedDocumentSpecification { get; set; } 

		[JsonProperty("requestedValueAddedServices")]
		public RequestedValueAddedServiceList RequestedValueAddedServices { get; set; } 

		/// <summary>
		/// The additional inputs required to purchase a shipping offering, in JSON format. The JSON provided
		/// here must adhere to the JSON schema that is returned in the response to the getAdditionalInputs
		/// operation.  Additional inputs are only required when indicated by the requiresAdditionalInputs
		/// property in the response to the getRates operation.
		/// </summary>
		[JsonProperty("additionalInputs")]
		public AdditionalInputs AdditionalInputs { get; set; } 
	}
}
