namespace AmznSellingPartner.Clients.Replenishment.Replenishment20221107
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    /// <summary>
    /// The attribute to use to sort the results.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ListOfferMetricsSortKey
    {
        /// <summary>
        /// The number of units shipped to the subscribers over a period of time. Applicable to PERFORMANCE
        /// timePeriodType.
        /// </summary>
        [EnumMember(Value = "SHIPPED_SUBSCRIPTION_UNITS")]
        SHIPPED_SUBSCRIPTION_UNITS,

        /// <summary>
        /// The revenue generated from subscriptions over a period of time. Applicable to PERFORMANCE
        /// timePeriodType.
        /// </summary>
        [EnumMember(Value = "TOTAL_SUBSCRIPTIONS_REVENUE")]
        TOTAL_SUBSCRIPTIONS_REVENUE,

        /// <summary>
        /// The number of active subscriptions present at the end of the period. Applicable to PERFORMANCE
        /// timePeriodType.
        /// </summary>
        [EnumMember(Value = "ACTIVE_SUBSCRIPTIONS")]
        ACTIVE_SUBSCRIPTIONS,

        /// <summary>
        /// The forecasted shipped subscription units for the next 90 days. Applicable to FORECAST tim
        /// ePeriodType.
        /// </summary>
        [EnumMember(Value = "NEXT_90DAYS_SHIPPED_SUBSCRIPTION_UNITS")]
        NEXT_90DAYS_SHIPPED_SUBSCRIPTION_UNITS,

        /// <summary>
        /// The forecasted shipped subscription units for the next 60 days. Applicable to FORECAST tim
        /// ePeriodType.
        /// </summary>
        [EnumMember(Value = "NEXT_60DAYS_SHIPPED_SUBSCRIPTION_UNITS")]
        NEXT_60DAYS_SHIPPED_SUBSCRIPTION_UNITS,

        /// <summary>
        /// The forecasted shipped subscription units for the next 30 days. Applicable to FORECAST tim
        /// ePeriodType.
        /// </summary>
        [EnumMember(Value = "NEXT_30DAYS_SHIPPED_SUBSCRIPTION_UNITS")]
        NEXT_30DAYS_SHIPPED_SUBSCRIPTION_UNITS,

        /// <summary>
        /// The forecasted total subscription revenue for the next 90 days. Applicable to FORECAST tim
        /// ePeriodType.
        /// </summary>
        [EnumMember(Value = "NEXT_90DAYS_TOTAL_SUBSCRIPTIONS_REVENUE")]
        NEXT_90DAYS_TOTAL_SUBSCRIPTIONS_REVENUE,

        /// <summary>
        /// The forecasted total subscription revenue for the next 60 days. Applicable to FORECAST tim
        /// ePeriodType.
        /// </summary>
        [EnumMember(Value = "NEXT_60DAYS_TOTAL_SUBSCRIPTIONS_REVENUE")]
        NEXT_60DAYS_TOTAL_SUBSCRIPTIONS_REVENUE,

        /// <summary>
        /// The forecasted total subscription revenue for the next 30 days. Applicable to FORECAST tim
        /// ePeriodType.
        /// </summary>
        [EnumMember(Value = "NEXT_30DAYS_TOTAL_SUBSCRIPTIONS_REVENUE")]
        NEXT_30DAYS_TOTAL_SUBSCRIPTIONS_REVENUE,
    }
}
