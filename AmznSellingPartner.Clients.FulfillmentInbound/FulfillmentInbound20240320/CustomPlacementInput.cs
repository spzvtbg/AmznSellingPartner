namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    using System.Collections.Generic;

    /// <summary>
    /// Provide units going to the warehouse.
    /// </summary>
    public class CustomPlacementInput : BaseClass
    {
        /// <summary>
        /// Items included while creating Inbound Plan.
        /// </summary>
        [JsonProperty("items")]
        [IsRequired]
        [MinItems(1)]
        [MaxItems(2000)]
        public List<ItemInput> Items { get; set; }

        /// <summary>
        /// Warehouse Id.
        /// </summary>
        [JsonProperty("warehouseId")]
        [IsRequired]
        [MinLength(1)]
        [MaxLength(1024)]
        public string WarehouseId { get; set; }
    }
}
