namespace AmznSellingPartner.Clients.SupplySources.SupplySources20200701
{
	using Newtonsoft.Json;

	public class SupplySourceListItem : BaseClass
	{
		[JsonProperty("alias")]
		public SupplySourceAlias Alias { get; set; }

		[JsonProperty("supplySourceId")]
		public SupplySourceId SupplySourceId { get; set; }

		[JsonProperty("supplySourceCode")]
		public SupplySourceCode SupplySourceCode { get; set; }

		[JsonProperty("address")]
		public Address Address { get; set; }
	}
}
