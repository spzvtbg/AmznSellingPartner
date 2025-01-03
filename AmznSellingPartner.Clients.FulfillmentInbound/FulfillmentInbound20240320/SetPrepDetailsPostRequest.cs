namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpPost("/inbound/fba/2024-03-20/items/prepDetails")]
	public class SetPrepDetailsPostRequest : BaseHttpRequest
	{
		/// <summary>
		/// The body of the request to `setPrepDetails`.
		/// </summary>
		[InBody("body")]
		[IsRequired]
		[JsonProperty("body")]
		public SetPrepDetailsRequest Body { get; set; }
	}
}
