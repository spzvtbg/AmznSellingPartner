namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpPost("/mfn/v0/shipments")]
	public class CreateShipmentPostRequest : BaseHttpRequest
	{
		/// <summary>
		/// The request schema for the `CreateShipment` operation.
		/// </summary>
		[InBody("body")]
		[IsRequired]
		[JsonProperty("body")]
		public CreateShipmentRequest Body { get; set; }
	}
}
