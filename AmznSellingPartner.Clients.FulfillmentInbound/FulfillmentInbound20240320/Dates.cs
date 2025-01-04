namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using Newtonsoft.Json;

	/// <summary>
	/// Specifies the date that the seller expects their shipment will be shipped.
	/// </summary>
	public class Dates : BaseClass
	{
		[JsonProperty("readyToShipWindow")]
		public Window ReadyToShipWindow { get; set; } 
	}
}
