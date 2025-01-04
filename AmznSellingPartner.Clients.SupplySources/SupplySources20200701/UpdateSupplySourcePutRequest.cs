namespace AmznSellingPartner.Clients.SupplySources.SupplySources20200701
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpPut("/supplySources/2020-07-01/supplySources/{supplySourceId}")]
	public class UpdateSupplySourcePutRequest : BaseHttpRequest
	{
		/// <summary>
		/// The unique identitier of a supply source.
		/// </summary>
		[InPath("supplySourceId")]
		[IsRequired]
		public string SupplySourceId { get; set; }

		[InBody("payload")]
		public UpdateSupplySourceRequest Payload { get; set; }
	}
}
