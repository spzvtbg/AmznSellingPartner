namespace AmznSellingPartner.Clients.SupplySources.SupplySources20200701
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpGet("/supplySources/2020-07-01/supplySources/{supplySourceId}")]
	public class AmznGetSupplySourceRequest : BaseHttpRequest
	{
		/// <summary>
		/// The unique identifier of a supply source.
		/// </summary>
		[InPath("supplySourceId")]
		[IsRequired]
		public string SupplySourceId { get; set; } 
	}
}
