namespace AmznSellingPartner.Clients.Invoices.InvoicesApiModel20240619
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpPost("/tax/invoices/2024-06-19/exports")]
    public class AmznCreateInvoicesExportRequest : BaseHttpRequest
    {
        /// <summary>
        /// Information required to create the export request.
        /// </summary>
        [InBody("body")]
        [IsRequired]
        public ExportInvoicesRequest Body { get; set; }
    }
}
