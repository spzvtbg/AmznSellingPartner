namespace AmznSellingPartner.Clients.DataKiosk.DataKiosk20231115
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpDelete("/dataKiosk/2023-11-15/queries/{queryId}")]
	public class AmznCancelQueryRequest : BaseHttpRequest
	{
		/// <summary>
		/// The identifier for the query. This identifier is unique only in combination with a selling
		/// partner account ID.
		/// </summary>
		[InPath("queryId")]
		[IsRequired]
		public string QueryId { get; set; } 
	}
}
