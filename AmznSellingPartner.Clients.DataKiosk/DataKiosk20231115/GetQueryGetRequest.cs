namespace AmznSellingPartner.Clients.DataKiosk.DataKiosk20231115
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpGet("/dataKiosk/2023-11-15/queries/{queryId}")]
	public class GetQueryGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// The query identifier.
		/// </summary>
		[InPath("queryId")]
		[IsRequired]
		[JsonProperty("queryId")]
		public string QueryId { get; set; }
	}
}
