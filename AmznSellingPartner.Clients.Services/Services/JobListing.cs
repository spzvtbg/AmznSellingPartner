namespace AmznSellingPartner.Clients.Services.Services
{
	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The payload for the `getServiceJobs` operation.
	/// </summary>
	public class JobListing : BaseClass
	{
		/// <summary>
		/// Total result size of the query result.
		/// </summary>
		[JsonProperty("totalResultSize")]
		public int TotalResultSize { get; set; } 

		/// <summary>
		/// A generated string used to pass information to your next request. If `nextPageToken` is returned,
		/// pass the value of `nextPageToken` to the `pageToken` to get next results.
		/// </summary>
		[JsonProperty("nextPageToken")]
		public string NextPageToken { get; set; } 

		/// <summary>
		/// A generated string used to pass information to your next request. If `previousPageToken` is
		/// returned, pass the value of `previousPageToken` to the `pageToken` to get previous page re
		/// sults.
		/// </summary>
		[JsonProperty("previousPageToken")]
		public string PreviousPageToken { get; set; } 

		/// <summary>
		/// List of job details for the given input.
		/// </summary>
		[JsonProperty("jobs")]
		public List<ServiceJob> Jobs { get; set; } 
	}
}
