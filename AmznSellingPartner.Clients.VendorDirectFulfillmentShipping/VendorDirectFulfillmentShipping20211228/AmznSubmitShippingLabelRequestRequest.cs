namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpPost("/vendor/directFulfillment/shipping/2021-12-28/shippingLabels")]
    public class AmznSubmitShippingLabelRequestRequest : BaseHttpRequest
    {
        /// <summary>
        /// The request body that contains the shipping labels data.
        /// </summary>
        [InBody("body")]
        [IsRequired]
        public SubmitShippingLabelsRequest Body { get; set; }
    }
}
