namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpGet("/vendor/directFulfillment/shipping/2021-12-28/packingSlips/{purchaseOrderNumber}")]
    public class AmznGetPackingSlipRequest : BaseHttpRequest
    {
        /// <summary>
        /// The `purchaseOrderNumber` for the packing slip that you want.
        /// </summary>
        [InPath("purchaseOrderNumber")]
        [IsRequired]
        [Pattern("^[a-zA-Z0-9]+")]
        public string PurchaseOrderNumber { get; set; }
    }
}
