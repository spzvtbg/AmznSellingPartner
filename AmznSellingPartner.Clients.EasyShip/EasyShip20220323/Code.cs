namespace AmznSellingPartner.Clients.EasyShip.EasyShip20220323
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    /// <summary>
    /// An error code that identifies the type of error that occurred. The error codes listed below
    /// are specific to the Easy Ship section.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Code
    {
        /// <summary>
        /// HTTP status code 400. Request has missing or invalid parameters and cannot be processed.
        /// </summary>
        [EnumMember(Value = "InvalidInput")]
        InvalidInput,

        /// <summary>
        /// HTTP status code 400. The specified time slot identifier is not valid.
        /// </summary>
        [EnumMember(Value = "InvalidTimeSlotId")]
        InvalidTimeSlotId,

        /// <summary>
        /// HTTP status code 400. The order has already been scheduled.
        /// </summary>
        [EnumMember(Value = "ScheduledPackageAlreadyExists")]
        ScheduledPackageAlreadyExists,

        /// <summary>
        /// HTTP status code 400. The selected time slot has expired. Try calling `listHandoverSlots` again
        /// to get a new time slot.
        /// </summary>
        [EnumMember(Value = "ScheduleWindowExpired")]
        ScheduleWindowExpired,

        /// <summary>
        /// HTTP status code 400. Order scheduling has failed because of an issue with the selected time
        /// slot. If you see this error, request a new time slot and try to schedule again.
        /// </summary>
        [EnumMember(Value = "RetryableAfterGettingNewSlots")]
        RetryableAfterGettingNewSlots,

        /// <summary>
        /// HTTP status code 404. No time slot is available due to various factors such as: invalid weight
        /// and dimension parameters, or the available slots are only available after the expected cancellation
        /// date.
        /// </summary>
        [EnumMember(Value = "TimeSlotNotAvailable")]
        TimeSlotNotAvailable,

        /// <summary>
        /// HTTP status code 404. The specified resource (for example, `amazonOrderId` or `marketplaceId`)
        /// does not exist.
        /// </summary>
        [EnumMember(Value = "ResourceNotFound")]
        ResourceNotFound,

        /// <summary>
        /// HTTP status code 404. The request cannot be applied to the order in its current state. For
        /// example, you cannot cancel an order which has not yet been scheduled or which has already been
        /// canceled.
        /// </summary>
        [EnumMember(Value = "InvalidOrderState")]
        InvalidOrderState,

        /// <summary>
        /// HTTP status code 404. Amazon Easy Ship is not supported in the specified marketplace.
        /// </summary>
        [EnumMember(Value = "RegionNotSupported")]
        RegionNotSupported,

        /// <summary>
        /// HTTP status code 405. Order is not eligible for rescheduling.
        /// </summary>
        [EnumMember(Value = "OrderNotEligibleForRescheduling")]
        OrderNotEligibleForRescheduling,

        /// <summary>
        /// HTTP status code 500. There was an internal service failure.
        /// </summary>
        [EnumMember(Value = "InternalServerError")]
        InternalServerError,
    }
}
