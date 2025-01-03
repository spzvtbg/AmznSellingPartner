namespace AmznSellingPartner.Clients.SupplySources.SupplySources20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpDelete("/supplySources/2020-07-01/supplySources/{supplySourceId}")]
	public class ArchiveSupplySourceDeleteRequest : BaseHttpRequest
	{
		/// <summary>
		/// The unique identifier of a supply source.
		/// </summary>
		[InPath("supplySourceId")]
		[IsRequired]
		[JsonProperty("supplySourceId")]
		public string SupplySourceId { get; set; }
	}
}
