namespace AmznSellingPartner.Clients.VendorInvoices.VendorInvoices
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// The aggregate weight of this item being invoiced. This information will be available for items
    /// sold by weight.
    /// </summary>
    public class TotalWeight : BaseClass
    {
        /// <summary>
        /// The unit of measure for items sold by weight.
        /// </summary>
        [JsonProperty("unitOfMeasure")]
        [IsRequired]
        public UnitOfMeasure UnitOfMeasure { get; set; }

        [JsonProperty("amount")]
        [IsRequired]
        public Decimal Amount { get; set; }
    }
}
