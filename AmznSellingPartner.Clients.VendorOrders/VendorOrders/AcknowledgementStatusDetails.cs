namespace AmznSellingPartner.Clients.VendorOrders.VendorOrders
{
    using AmznSellingPartner.Clients.Values;

    using Newtonsoft.Json;

    /// <summary>
    /// Details of item quantity ordered
    /// </summary>
    public class AcknowledgementStatusDetails : BaseClass
    {
        /// <summary>
        /// The date when the line item was confirmed by vendor. Must be in ISO-8601 date/time format.
        /// </summary>
        [JsonProperty("acknowledgementDate")]
        public DateTimeValue AcknowledgementDate { get; set; }

        /// <summary>
        /// Item quantity accepted by vendor to be shipped.
        /// </summary>
        [JsonProperty("acceptedQuantity")]
        public ItemQuantity AcceptedQuantity { get; set; }

        /// <summary>
        /// Item quantity rejected by vendor.
        /// </summary>
        [JsonProperty("rejectedQuantity")]
        public ItemQuantity RejectedQuantity { get; set; }
    }
}
