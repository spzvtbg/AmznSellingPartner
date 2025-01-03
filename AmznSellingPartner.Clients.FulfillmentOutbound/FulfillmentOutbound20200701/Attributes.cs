namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using Newtonsoft.Json;

	public class Attributes : BaseClass
	{
		[JsonProperty("AdditionalValue")]
		public string AdditionalValue { get; set; }
	}
}
