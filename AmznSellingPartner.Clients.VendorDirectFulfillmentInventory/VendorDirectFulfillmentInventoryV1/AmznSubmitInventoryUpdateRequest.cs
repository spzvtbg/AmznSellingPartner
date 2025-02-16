namespace AmznSellingPartner.Clients.VendorDirectFulfillmentInventory.VendorDirectFulfillmentInventoryV1
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpPost("/vendor/directFulfillment/inventory/v1/warehouses/{warehouseId}/items")]
    public class AmznSubmitInventoryUpdateRequest : BaseHttpRequest
    {
        /// <summary>
        /// The request body containing the inventory update data to submit.
        /// </summary>
        [InBody("body")]
        [IsRequired]
        public SubmitInventoryUpdateRequest Body { get; set; }

        /// <summary>
        /// Identifier for the warehouse for which to update inventory.
        /// </summary>
        [InPath("warehouseId")]
        [IsRequired]
        public string WarehouseId { get; set; }
    }
}
