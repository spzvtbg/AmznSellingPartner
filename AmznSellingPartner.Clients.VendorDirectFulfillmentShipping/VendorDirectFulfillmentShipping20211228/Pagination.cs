namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
	using Newtonsoft.Json;

	/// <summary>
	/// The pagination elements required to retrieve the remaining data.
	/// </summary>
	public class Pagination : BaseClass
	{
		/// <summary>
		/// Pagination occurs when a request produces a response that exceeds the `pageSize`. This means that the response
		/// is divided into individual pages. To retrieve the next page or the previous page, you must pass the `nextToken
		/// value or the `previousToken` value as the `pageToken` parameter in the next request. There is no `nextToken`
		/// n the pagination object on the last page.
		/// </summary>
		[JsonProperty("nextToken")]
		public string NextToken { get; set; }
	}
}
