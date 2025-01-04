namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Contains tokens to fetch from a certain page.
	/// </summary>
	public class Pagination : BaseClass
	{
		/// <summary>
		/// When present, pass this string token in the next request to return the next response page.
		/// </summary>
		[JsonProperty("nextToken")]
		[MinLength(1)]
		[MaxLength(1024)]
		public string NextToken { get; set; }
	}
}
