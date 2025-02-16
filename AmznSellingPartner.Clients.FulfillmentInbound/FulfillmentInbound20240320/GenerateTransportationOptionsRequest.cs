namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    using System.Collections.Generic;

    /// <summary>
    /// The `generateTransportationOptions` request.
    /// </summary>
    public class GenerateTransportationOptionsRequest : BaseClass
    {
        /// <summary>
        /// The placement option to generate transportation options for.
        /// </summary>
        [JsonProperty("placementOptionId")]
        [IsRequired]
        [Pattern("^[a-zA-Z0-9-]*")]
        [MinLength(38)]
        [MaxLength(38)]
        public string PlacementOptionId { get; set; }

        /// <summary>
        /// List of shipment transportation configurations.
        /// </summary>
        [JsonProperty("shipmentTransportationConfigurations")]
        [IsRequired]
        [MinItems(1)]
        public List<ShipmentTransportationConfiguration> ShipmentTransportationConfigurations { get; set; }
    }
}
