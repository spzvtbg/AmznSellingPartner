namespace AmznSellingPartner.Clients.SupplySources.SupplySources20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The result of creating a new supply source.
	/// </summary>
	public class CreateSupplySourceResponse : BaseClass
	{
		[IsRequired]
		[JsonProperty("supplySourceId")]
		public SupplySourceId SupplySourceId { get; set; }

		[IsRequired]
		[JsonProperty("supplySourceCode")]
		public SupplySourceCode SupplySourceCode { get; set; }
	}
}
