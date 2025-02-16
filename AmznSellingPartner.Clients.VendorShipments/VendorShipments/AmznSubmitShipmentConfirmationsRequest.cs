namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpPost("/vendor/shipping/v1/shipmentConfirmations")]
    public class AmznSubmitShipmentConfirmationsRequest : BaseHttpRequest
    {
        /// <summary>
        /// A request to submit shipment confirmation.
        /// </summary>
        [InBody("body")]
        [IsRequired]
        public SubmitShipmentConfirmationsRequest Body { get; set; }
    }
}
