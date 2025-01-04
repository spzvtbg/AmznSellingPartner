namespace AmznSellingPartner.Clients.DataKiosk.DataKiosk20231115
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpGet("/dataKiosk/2023-11-15/documents/{documentId}")]
	public class GetDocumentGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// The identifier for the Data Kiosk document.
		/// </summary>
		[InPath("documentId")]
		[IsRequired]
		public string DocumentId { get; set; }
	}
}
