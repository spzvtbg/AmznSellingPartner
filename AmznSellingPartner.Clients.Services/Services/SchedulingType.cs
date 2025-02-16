namespace AmznSellingPartner.Clients.Services.Services
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SchedulingType
    {
        /// <summary>
        /// The slots provided are backed by inventory in inventory management system.
        /// </summary>
        [EnumMember(Value = "REAL_TIME_SCHEDULING")]
        REAL_TIME_SCHEDULING,

        /// <summary>
        /// The slots provided are based on working hours defined in seller management system.
        /// </summary>
        [EnumMember(Value = "NON_REAL_TIME_SCHEDULING")]
        NON_REAL_TIME_SCHEDULING,
    }
}
