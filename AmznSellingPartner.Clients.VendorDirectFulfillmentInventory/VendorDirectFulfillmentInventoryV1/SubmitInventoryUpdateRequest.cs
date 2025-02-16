namespace AmznSellingPartner.Clients.VendorDirectFulfillmentInventory.VendorDirectFulfillmentInventoryV1
{
    using Newtonsoft.Json;

    /// <summary>
    /// The request body for the submitInventoryUpdate operation.
    /// </summary>
    public class SubmitInventoryUpdateRequest : BaseClass
    {
        /// <summary>
        /// Inventory details required to update some or all items for the requested warehouse.
        /// </summary>
        [JsonProperty("inventory")]
        public InventoryUpdate Inventory { get; set; }
    }
}
