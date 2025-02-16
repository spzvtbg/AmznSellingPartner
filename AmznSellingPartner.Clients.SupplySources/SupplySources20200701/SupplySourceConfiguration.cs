namespace AmznSellingPartner.Clients.SupplySources.SupplySources20200701
{
    using Newtonsoft.Json;

    /// <summary>
    /// Includes configuration and timezone of a supply source.
    /// </summary>
    public class SupplySourceConfiguration : BaseClass
    {
        [JsonProperty("operationalConfiguration")]
        public OperationalConfiguration OperationalConfiguration { get; set; }

        /// <summary>
        /// Please see RFC 6557, should be a canonical time zone ID as listed here: https://www.joda.o
        /// rg/joda-time/timezones.html.
        /// </summary>
        [JsonProperty("timezone")]
        public string Timezone { get; set; }
    }
}
