namespace AmznSellingPartner.Clients.ListingsItems.ListingsItems20210801
{
    using AmznSellingPartner.Clients.ValidationAttributes;
    using AmznSellingPartner.Clients.Values;

    using Newtonsoft.Json;

    /// <summary>
    /// Conveying the status of the listed enforcement actions and, if applicable, provides information
    /// about the exemption's expiry date.
    /// </summary>
    public class IssueExemption : BaseClass
    {
        /// <summary>
        /// This field indicates the current exemption status for the listed enforcement actions. It can
        /// take values such as `EXEMPT`, signifying permanent exemption, `EXEMPT_UNTIL_EXPIRY_DATE` indicating
        /// temporary exemption until a specified date, or `NOT_EXEMPT` signifying no exemptions, and enforcement
        /// actions were already applied.
        /// </summary>
        [JsonProperty("status")]
        [IsRequired]
        public Status Status { get; set; }

        /// <summary>
        /// This field represents the timestamp, following the ISO 8601 format, which specifies the date
        /// when temporary exemptions, if applicable, will expire, and Amazon will begin enforcing the
        /// listed actions.
        /// </summary>
        [JsonProperty("expiryDate")]
        public DateTimeValue ExpiryDate { get; set; }
    }
}
