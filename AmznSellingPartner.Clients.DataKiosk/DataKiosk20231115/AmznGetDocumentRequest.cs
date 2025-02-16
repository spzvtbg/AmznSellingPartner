namespace AmznSellingPartner.Clients.DataKiosk.DataKiosk20231115
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpGet("/dataKiosk/2023-11-15/documents/{documentId}")]
    public class AmznGetDocumentRequest : BaseHttpRequest
    {
        /// <summary>
        /// The identifier for the Data Kiosk document.
        /// </summary>
        [InPath("documentId")]
        [IsRequired]
        public string DocumentId { get; set; }
    }
}
