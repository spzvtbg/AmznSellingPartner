namespace AmznSellingPartner.Clients.Invoices.InvoicesApiModel20240619
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpGet("/tax/invoices/2024-06-19/attributes")]
    public class AmznGetInvoicesAttributesRequest : BaseHttpRequest
    {
        /// <summary>
        /// The marketplace identifier.
        /// </summary>
        [InQuery("marketplaceId")]
        [IsRequired]
        public string MarketplaceId { get; set; }
    }
}
