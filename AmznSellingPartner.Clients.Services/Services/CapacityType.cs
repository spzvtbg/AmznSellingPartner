namespace AmznSellingPartner.Clients.Services.Services
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    /// <summary>
    /// Type of capacity
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CapacityType
    {
        /// <summary>
        /// This capacity represents the originally allocated capacity as per resource schedule.
        /// </summary>
        [EnumMember(Value = "SCHEDULED_CAPACITY")]
        SCHEDULED_CAPACITY,

        /// <summary>
        /// This capacity represents the capacity available for allocation to reservations.
        /// </summary>
        [EnumMember(Value = "AVAILABLE_CAPACITY")]
        AVAILABLE_CAPACITY,

        /// <summary>
        /// This capacity represents the capacity allocated for Amazon Jobs/Appointments/Orders.
        /// </summary>
        [EnumMember(Value = "ENCUMBERED_CAPACITY")]
        ENCUMBERED_CAPACITY,

        /// <summary>
        /// This capacity represents the capacity made unavailable due to events like Breaks/Leaves/Lu
        /// nch.
        /// </summary>
        [EnumMember(Value = "RESERVED_CAPACITY")]
        RESERVED_CAPACITY,
    }
}
