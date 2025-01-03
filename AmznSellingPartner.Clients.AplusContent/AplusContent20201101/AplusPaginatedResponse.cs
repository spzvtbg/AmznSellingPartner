namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using Newtonsoft.Json;

	/// <summary>
	/// The base response data for paginated A+ Content operations
	/// Individual operations may extend this with additional data
	/// If nextPageToken is not returned, there are no more pages to return
	/// </summary>
	public class AplusPaginatedResponse : BaseClass
	{
		[JsonProperty("nextPageToken")]
		public PageToken NextPageToken { get; set; }
	}
}
