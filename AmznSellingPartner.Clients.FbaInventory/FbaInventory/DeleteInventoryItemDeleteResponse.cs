namespace AmznSellingPartner.Clients.FbaInventory.FbaInventory
{
	using AmznSellingPartner.Clients.Attributes;

	public class DeleteInventoryItemDeleteResponse : BaseHttpResponse
	{
		/// <summary>
		/// Unique request reference identifier.
		/// </summary>
		[FromHeader("x-amzn-RequestId")]
		public string XAmznRequestId { get; set; } 

		/// <summary>
		/// OK
		/// </summary>
		public DeleteInventoryItemResponse DeleteInventoryItemResponse { get; set; } 
	}
}
