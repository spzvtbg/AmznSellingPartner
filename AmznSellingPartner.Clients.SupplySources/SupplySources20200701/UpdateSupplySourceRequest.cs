namespace AmznSellingPartner.Clients.SupplySources.SupplySources20200701
{
	using Newtonsoft.Json;

	/// <summary>
	/// A request to update the configuration and capabilities of a supply source
	/// </summary>
	public class UpdateSupplySourceRequest : BaseClass
	{
		[JsonProperty("alias")]
		public SupplySourceAlias Alias { get; set; }

		[JsonProperty("configuration")]
		public SupplySourceConfiguration Configuration { get; set; }

		[JsonProperty("capabilities")]
		public SupplySourceCapabilities Capabilities { get; set; }
	}
}
