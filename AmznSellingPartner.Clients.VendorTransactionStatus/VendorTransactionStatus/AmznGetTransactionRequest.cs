namespace AmznSellingPartner.Clients.VendorTransactionStatus.VendorTransactionStatus
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpGet("/vendor/transactions/v1/transactions/{transactionId}")]
	public class AmznGetTransactionRequest : BaseHttpRequest
	{
		/// <summary>
		/// The GUID provided by Amazon in the 'transactionId' field in response to the post request of
		/// a specific transaction.
		/// </summary>
		[InPath("transactionId")]
		[IsRequired]
		public string TransactionId { get; set; } 
	}
}
