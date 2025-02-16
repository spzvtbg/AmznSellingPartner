namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpPost("/vendor/directFulfillment/shipping/2021-12-28/containerLabel")]
    public class AmznCreateContainerLabelRequest : BaseHttpRequest
    {
        /// <summary>
        /// Request body containing the container label data.
        /// </summary>
        [InBody("body")]
        [IsRequired]
        public CreateContainerLabelRequest Body { get; set; }
    }
}
