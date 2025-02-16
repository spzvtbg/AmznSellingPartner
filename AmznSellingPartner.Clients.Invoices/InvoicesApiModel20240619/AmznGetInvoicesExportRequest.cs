namespace AmznSellingPartner.Clients.Invoices.InvoicesApiModel20240619
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpGet("/tax/invoices/2024-06-19/exports/{exportId}")]
    public class AmznGetInvoicesExportRequest : BaseHttpRequest
    {
        /// <summary>
        /// The unique identifier for the export.
        /// </summary>
        [InPath("exportId")]
        [IsRequired]
        public string ExportId { get; set; }
    }
}
