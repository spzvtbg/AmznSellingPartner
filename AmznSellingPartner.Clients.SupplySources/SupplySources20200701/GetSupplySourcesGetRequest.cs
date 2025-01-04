namespace AmznSellingPartner.Clients.SupplySources.SupplySources20200701
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpGet("/supplySources/2020-07-01/supplySources")]
	public class GetSupplySourcesGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// The pagination token to retrieve a specific page of results.
		/// </summary>
		[InQuery("nextPageToken")]
		public string NextPageToken { get; set; }

		/// <summary>
		/// The number of supply sources to return per paginated request.
		/// </summary>
		[InQuery("pageSize")]
		public double PageSize { get; set; }
	}
}
