namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The common properties for responses to individual requests within a batch.
	/// </summary>
	public class BatchResponse : BaseClass
	{
		[JsonProperty("headers")]
		[IsRequired]
		public HttpHeaders Headers { get; set; } 

		[JsonProperty("status")]
		[IsRequired]
		public HttpStatusLine Status { get; set; } 
	}
}
