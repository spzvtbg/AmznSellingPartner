namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
    using AmznSellingPartner.Clients.Values;

    using Newtonsoft.Json;

    /// <summary>
    /// Date Range for query the results.
    /// </summary>
    public class DateRange : BaseClass
    {
        /// <summary>
        /// Start Date for query .
        /// </summary>
        [JsonProperty("startDate")]
        public DateTimeValue StartDate { get; set; }

        /// <summary>
        /// end date for query.
        /// </summary>
        [JsonProperty("endDate")]
        public DateTimeValue EndDate { get; set; }
    }
}
