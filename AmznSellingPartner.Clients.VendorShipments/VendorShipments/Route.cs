namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    using System.Collections.Generic;

    /// <summary>
    /// This is used only for direct import shipment confirmations.
    /// </summary>
    public class Route : BaseClass
    {
        /// <summary>
        /// The port or location involved in transporting the cargo, as specified in transportation contracts
        /// or operational plans.
        /// </summary>
        [JsonProperty("stops")]
        [IsRequired]
        public List<Stop> Stops { get; set; }
    }
}
