namespace AmznSellingPartner.Clients.SupplySources.SupplySources20200701
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpPut("/supplySources/2020-07-01/supplySources/{supplySourceId}/status")]
	public class UpdateSupplySourceStatusPutRequest : BaseHttpRequest
	{
		/// <summary>
		/// The unique identifier of a supply source.
		/// </summary>
		[InPath("supplySourceId")]
		[IsRequired]
		public string SupplySourceId { get; set; } 

		[InBody("payload")]
		public UpdateSupplySourceStatusRequest Payload { get; set; } 
	}
}
