namespace AmznSellingPartner.Clients.DataKiosk.DataKiosk20231115
{
	using Newtonsoft.Json;

	public class Pagination : BaseClass
	{
		/// <summary>
		/// A token that can be used to fetch the next page of results
		/// </summary>
		[JsonProperty("nextToken")]
		public string NextToken { get; set; }
	}
}
