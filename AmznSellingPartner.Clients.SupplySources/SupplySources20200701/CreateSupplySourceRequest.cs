namespace AmznSellingPartner.Clients.SupplySources.SupplySources20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// A request to create a supply source
	/// </summary>
	public class CreateSupplySourceRequest : BaseClass
	{
		[IsRequired]
		[JsonProperty("supplySourceCode")]
		public SupplySourceCode SupplySourceCode { get; set; }

		[IsRequired]
		[JsonProperty("alias")]
		public SupplySourceAlias Alias { get; set; }

		[IsRequired]
		[JsonProperty("address")]
		public Address Address { get; set; }
	}
}
