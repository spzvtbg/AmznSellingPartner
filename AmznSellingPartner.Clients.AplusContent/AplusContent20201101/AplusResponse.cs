namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using Newtonsoft.Json;

	/// <summary>
	/// The base response data for all A+ Content operations when a request is successful or partially successful.
	/// Individual operations may extend this with additional data.
	/// </summary>
	public class AplusResponse : BaseClass
	{
		[JsonProperty("warnings")]
		public MessageSet Warnings { get; set; }
	}
}
