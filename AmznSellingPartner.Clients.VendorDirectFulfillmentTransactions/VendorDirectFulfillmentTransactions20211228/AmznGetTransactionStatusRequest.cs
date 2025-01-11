namespace AmznSellingPartner.Clients.VendorDirectFulfillmentTransactions.VendorDirectFulfillmentTransactions20211228
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpGet("/vendor/directFulfillment/transactions/2021-12-28/transactions/{transactionId}")]
	public class AmznGetTransactionStatusRequest : BaseHttpRequest
	{
		/// <summary>
		/// Previously returned in the response to the POST request of a specific transaction.
		/// </summary>
		[InPath("transactionId")]
		[IsRequired]
		public string TransactionId { get; set; } 
	}
}
