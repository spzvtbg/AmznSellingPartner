namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The `updateShipmentTrackingDetails` request.
	/// </summary>
	public class UpdateShipmentTrackingDetailsRequest : BaseClass
	{
		[JsonProperty("trackingDetails")]
		[IsRequired]
		public TrackingDetailsInput TrackingDetails { get; set; } 
	}
}
