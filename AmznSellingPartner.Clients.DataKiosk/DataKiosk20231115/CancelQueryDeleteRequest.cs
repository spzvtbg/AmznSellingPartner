namespace AmznSellingPartner.Clients.DataKiosk.DataKiosk20231115
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpDelete("/dataKiosk/2023-11-15/queries/{queryId}")]
	public class CancelQueryDeleteRequest : BaseHttpRequest
	{
		/// <summary>
		/// The identifier for the query. This identifier is unique only in combination with a selling partner account
		/// ID.
		/// </summary>
		[InPath("queryId")]
		[IsRequired]
		[JsonProperty("queryId")]
		public string QueryId { get; set; }
	}
}
