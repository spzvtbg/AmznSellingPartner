namespace AmznSellingPartner.Clients.ListingsItems.ListingsItems20210801
{
	using Newtonsoft.Json;

	/// <summary>
	/// When a request produces a response that exceeds the `pageSize`, pagination occurs. This means the response
	/// is divided into individual pages. To retrieve the next page or the previous page, you must pass the `nextToken`
	/// value or the `previousToken` value as the `pageToken` parameter in the next request. When you receive
	/// the last page, there will be no `nextToken` key in the pagination object.
	/// </summary>
	public class Pagination : BaseClass
	{
		/// <summary>
		/// A token that can be used to fetch the next page.
		/// </summary>
		[JsonProperty("nextToken")]
		public string NextToken { get; set; } 

		/// <summary>
		/// A token that can be used to fetch the previous page.
		/// </summary>
		[JsonProperty("previousToken")]
		public string PreviousToken { get; set; } 
	}
}
