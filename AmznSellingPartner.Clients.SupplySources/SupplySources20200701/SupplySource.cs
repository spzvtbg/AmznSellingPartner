namespace AmznSellingPartner.Clients.SupplySources.SupplySources20200701
{
	using Newtonsoft.Json;

	/// <summary>
	/// The supply source details, including configurations and capabilities.
	/// </summary>
	public class SupplySource : BaseClass
	{
		[JsonProperty("supplySourceId")]
		public SupplySourceId SupplySourceId { get; set; } 

		[JsonProperty("supplySourceCode")]
		public SupplySourceCode SupplySourceCode { get; set; } 

		[JsonProperty("alias")]
		public SupplySourceAlias Alias { get; set; } 

		[JsonProperty("status")]
		public SupplySourceStatusReadOnly Status { get; set; } 

		[JsonProperty("address")]
		public Address Address { get; set; } 

		[JsonProperty("configuration")]
		public SupplySourceConfiguration Configuration { get; set; } 

		[JsonProperty("capabilities")]
		public SupplySourceCapabilities Capabilities { get; set; } 

		[JsonProperty("createdAt")]
		public DateTime CreatedAt { get; set; } 

		[JsonProperty("updatedAt")]
		public DateTime UpdatedAt { get; set; } 
	}
}
