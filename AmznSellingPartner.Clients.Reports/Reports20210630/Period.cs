namespace AmznSellingPartner.Clients.Reports.Reports20210630
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Period
    {
        /// <summary>
        /// 5 minutes
        /// </summary>
        [EnumMember(Value = "PT5M")]
        PT5M,

        /// <summary>
        /// 15 minutes
        /// </summary>
        [EnumMember(Value = "PT15M")]
        PT15M,

        /// <summary>
        /// 30 minutes
        /// </summary>
        [EnumMember(Value = "PT30M")]
        PT30M,

        /// <summary>
        /// 1 hour
        /// </summary>
        [EnumMember(Value = "PT1H")]
        PT1H,

        /// <summary>
        /// 2 hours
        /// </summary>
        [EnumMember(Value = "PT2H")]
        PT2H,

        /// <summary>
        /// 4 hours
        /// </summary>
        [EnumMember(Value = "PT4H")]
        PT4H,

        /// <summary>
        /// 8 hours
        /// </summary>
        [EnumMember(Value = "PT8H")]
        PT8H,

        /// <summary>
        /// 12 hours
        /// </summary>
        [EnumMember(Value = "PT12H")]
        PT12H,

        /// <summary>
        /// 1 day
        /// </summary>
        [EnumMember(Value = "P1D")]
        P1D,

        /// <summary>
        /// 2 days
        /// </summary>
        [EnumMember(Value = "P2D")]
        P2D,

        /// <summary>
        /// 3 days
        /// </summary>
        [EnumMember(Value = "P3D")]
        P3D,

        /// <summary>
        /// 84 hours
        /// </summary>
        [EnumMember(Value = "PT84H")]
        PT84H,

        /// <summary>
        /// 7 days
        /// </summary>
        [EnumMember(Value = "P7D")]
        P7D,

        /// <summary>
        /// 14 days
        /// </summary>
        [EnumMember(Value = "P14D")]
        P14D,

        /// <summary>
        /// 15 days
        /// </summary>
        [EnumMember(Value = "P15D")]
        P15D,

        /// <summary>
        /// 18 days
        /// </summary>
        [EnumMember(Value = "P18D")]
        P18D,

        /// <summary>
        /// 30 days
        /// </summary>
        [EnumMember(Value = "P30D")]
        P30D,

        /// <summary>
        /// 1 month
        /// </summary>
        [EnumMember(Value = "P1M")]
        P1M,
    }
}
