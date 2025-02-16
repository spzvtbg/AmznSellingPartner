namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// The shipper instruction.
    /// </summary>
    public class ShipperInstruction : BaseClass
    {
        /// <summary>
        /// The delivery notes for the shipment
        /// </summary>
        [JsonProperty("deliveryNotes")]
        [MaxLength(256)]
        public string DeliveryNotes { get; set; }
    }
}
