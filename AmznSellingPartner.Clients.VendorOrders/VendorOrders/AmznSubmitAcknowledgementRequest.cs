namespace AmznSellingPartner.Clients.VendorOrders.VendorOrders
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpPost("/vendor/orders/v1/acknowledgements")]
    public class AmznSubmitAcknowledgementRequest : BaseHttpRequest
    {
        /// <summary>
        /// Submits acknowledgements for one or more purchase orders from a vendor.
        /// </summary>
        [InBody("body")]
        [IsRequired]
        public SubmitAcknowledgementRequest Body { get; set; }
    }
}
