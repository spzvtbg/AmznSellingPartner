namespace AmznSellingPartner.Clients.VendorDirectFulfillmentInventory.VendorDirectFulfillmentInventoryV1
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// Details of item quantity.
    /// </summary>
    public class ItemQuantity : BaseClass
    {
        /// <summary>
        /// Quantity of units available for a specific item.
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// Unit of measure for the available quantity.
        /// </summary>
        [JsonProperty("unitOfMeasure")]
        [IsRequired]
        public string UnitOfMeasure { get; set; }
    }
}
