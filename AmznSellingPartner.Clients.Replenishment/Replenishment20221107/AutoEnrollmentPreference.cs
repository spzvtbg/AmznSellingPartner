namespace AmznSellingPartner.Clients.Replenishment.Replenishment20221107
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    /// <summary>
    /// The auto-enrollment preference indicates whether the offer is opted-in to or opted-out of Amazon's
    /// auto-enrollment feature.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AutoEnrollmentPreference
    {
        /// <summary>
        /// The offer is opted-in to the auto-enrollment program.
        /// </summary>
        [EnumMember(Value = "OPTED_IN")]
        OPTED_IN,

        /// <summary>
        /// The offer is opted-out to the auto-enrollment program.
        /// </summary>
        [EnumMember(Value = "OPTED_OUT")]
        OPTED_OUT,
    }
}
