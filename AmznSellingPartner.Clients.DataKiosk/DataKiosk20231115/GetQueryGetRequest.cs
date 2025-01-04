namespace AmznSellingPartner.Clients.DataKiosk.DataKiosk20231115
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpGet("/dataKiosk/2023-11-15/queries/{queryId}")]
	public class GetQueryGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// The query identifier.
		/// </summary>
		[InPath("queryId")]
		[IsRequired]
		public string QueryId { get; set; }
	}
}
