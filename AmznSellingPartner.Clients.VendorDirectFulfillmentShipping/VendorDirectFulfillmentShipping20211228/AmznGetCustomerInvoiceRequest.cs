namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpGet("/vendor/directFulfillment/shipping/2021-12-28/customerInvoices/{purchaseOrderNumber}")]
    public class AmznGetCustomerInvoiceRequest : BaseHttpRequest
    {
        /// <summary>
        /// Purchase order number of the shipment for which to return the invoice.
        /// </summary>
        [InPath("purchaseOrderNumber")]
        [IsRequired]
        [Pattern("^[a-zA-Z0-9]+")]
        public string PurchaseOrderNumber { get; set; }
    }
}
