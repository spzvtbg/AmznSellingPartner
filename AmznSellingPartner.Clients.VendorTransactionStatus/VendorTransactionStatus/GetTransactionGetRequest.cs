namespace AmznSellingPartner.Clients.VendorTransactionStatus.VendorTransactionStatus
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpGet("/vendor/transactions/v1/transactions/{transactionId}")]
	public class GetTransactionGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// The GUID provided by Amazon in the 'transactionId' field in response to the post request of a specific transac
		/// ion.
		/// </summary>
		[InPath("transactionId")]
		[IsRequired]
		[JsonProperty("transactionId")]
		public string TransactionId { get; set; }
	}
}
