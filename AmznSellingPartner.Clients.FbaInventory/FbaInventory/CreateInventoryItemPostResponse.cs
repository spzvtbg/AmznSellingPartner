namespace AmznSellingPartner.Clients.FbaInventory.FbaInventory
{
	using AmznSellingPartner.Clients.Attributes;

	public class CreateInventoryItemPostResponse : BaseHttpResponse<CreateInventoryItemPostResponse>
	{
		/// <summary>
		/// Unique request reference identifier.
		/// </summary>
		[FromHeader("x-amzn-RequestId")]
		public string XAmznRequestId { get; set; } 

		public bool Succeeded { get; set; } 

		/// <summary>
		/// OK
		/// </summary>
		public CreateInventoryItemResponse CreateInventoryItemResponse { get; set; } 
	}
}
