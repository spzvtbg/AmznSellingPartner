namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
    using Newtonsoft.Json;

    using System.Collections.Generic;

    /// <summary>
    /// The request schema for the SubmitShipments operation.
    /// </summary>
    public class SubmitShipments : BaseClass
    {
        /// <summary>
        /// A list of one or more shipments with underlying details.
        /// </summary>
        [JsonProperty("shipments")]
        public List<Shipment> Shipments { get; set; }
    }
}
