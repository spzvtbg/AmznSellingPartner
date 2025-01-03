namespace AmznSellingPartner.Clients.DataKiosk.DataKiosk20231115
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpGet("/dataKiosk/2023-11-15/documents/{documentId}")]
	public class GetDocumentGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// The identifier for the Data Kiosk document.
		/// </summary>
		[InPath("documentId")]
		[IsRequired]
		[JsonProperty("documentId")]
		public string DocumentId { get; set; }
	}
}
