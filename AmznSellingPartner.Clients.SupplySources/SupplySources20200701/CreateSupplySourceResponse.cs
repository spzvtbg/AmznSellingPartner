namespace AmznSellingPartner.Clients.SupplySources.SupplySources20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The result of creating a new supply source.
	/// </summary>
	public class CreateSupplySourceResponse : BaseClass
	{
		[JsonProperty("supplySourceId")]
		[IsRequired]
		public SupplySourceId SupplySourceId { get; set; } 

		[JsonProperty("supplySourceCode")]
		[IsRequired]
		public SupplySourceCode SupplySourceCode { get; set; } 
	}
}
