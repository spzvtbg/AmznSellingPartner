namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The payload for the `getFeatures` operation.
	/// </summary>
	public class GetFeaturesResult : BaseClass
	{
		[JsonProperty("features")]
		[IsRequired]
		public Features Features { get; set; } 
	}
}
