namespace AmznSellingPartner.Clients.FbaInventory.FbaInventory
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpPost("/fba/inventory/v1/items/inventory")]
	public class AddInventoryPostRequest : BaseHttpRequest
	{
		/// <summary>
		/// A unique token/requestId provided with each call to ensure idempotency.
		/// </summary>
		[InHeader("x-amzn-idempotency-token")]
		[IsRequired]
		public string XAmznIdempotencyToken { get; set; } 

		/// <summary>
		/// List of items to add to Sandbox inventory.
		/// </summary>
		[InBody("addInventoryRequestBody")]
		[IsRequired]
		public AddInventoryRequest AddInventoryRequestBody { get; set; } 
	}
}
