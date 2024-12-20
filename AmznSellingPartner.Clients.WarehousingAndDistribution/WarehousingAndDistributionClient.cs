namespace AmznSellingPartner.Clients.WarehousingAndDistribution
{
    public class WarehousingAndDistributionClient
    {
        /// <summary>
        /// Retrieves an AWD inbound shipment.
        /// | Rate (requests per second) | Burst |
        /// | -------------------------- | ----- |
        /// |                          2 |     2 |
        /// The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that 
        /// were applied to the requested operation, when available. 
        /// The table above indicates the default rate and burst values for this operation. 
        /// Selling partners whose business demands require higher throughput may 
        /// see higher rate and burst values than those shown here. 
        /// For more information, refer to: 
        /// https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api
        /// </summary>
        public void GetInboundShipment(string shipmentId, SkuQuantities skuQuantities)
        {
            var path = $"/awd/2024-05-09/inboundShipments/{shipmentId}?skuQuantities={skuQuantities}";
        }
    }
}
