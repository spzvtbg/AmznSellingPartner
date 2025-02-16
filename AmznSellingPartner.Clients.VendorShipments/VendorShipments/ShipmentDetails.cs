namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
    using Newtonsoft.Json;

    using System.Collections.Generic;

    /// <summary>
    /// The request schema for the GetShipmentDetails operation.
    /// </summary>
    public class ShipmentDetails : BaseClass
    {
        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }

        /// <summary>
        /// A list of one or more shipments with underlying details.
        /// </summary>
        [JsonProperty("shipments")]
        public List<Shipment> Shipments { get; set; }
    }
}
