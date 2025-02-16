namespace AmznSellingPartner.Clients.ListingsItems.ListingsItems20210801
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Status
    {
        /// <summary>
        /// The listings item can be purchased by shoppers. This status does not apply to vendor listi
        /// ngs.
        /// </summary>
        [EnumMember(Value = "BUYABLE")]
        BUYABLE,

        /// <summary>
        /// The listings item is visible to shoppers.
        /// </summary>
        [EnumMember(Value = "DISCOVERABLE")]
        DISCOVERABLE,

        /// <summary>
        /// This status is assigned to a product listing when it has been exempted from the listed enforcement
        /// actions. In cases of `EXEMPT`, Amazon acknowledges the existence of enforcement actions but
        /// ensures the user that these actions will not be applied to the listing. The user is advised
        /// to consider addressing the issue, although enforcement actions will not be taken.
        /// </summary>
        [EnumMember(Value = "EXEMPT")]
        EXEMPT,

        /// <summary>
        /// This status indicates that a product listing has been granted a temporary exemption from the
        /// listed enforcement actions. The exemption will remain in effect until a specified expiry date.
        /// After this date, Amazon will enforce the listed actions. The `expiryDate` field provides the
        /// timestamp indicating when the temporary exemption will end, adhering to the ISO 8601 forma
        /// t
        /// </summary>
        [EnumMember(Value = "EXEMPT_UNTIL_EXPIRY_DATE")]
        EXEMPT_UNTIL_EXPIRY_DATE,

        /// <summary>
        /// This status is assigned to a product listing when it has no exemptions from the listed enforcement
        /// actions. When the status is `NOT_EXEMPT`, it signifies that Amazon has already taken the specified
        /// enforcement actions. There is no exemption in place, and the listed actions are actively e
        /// nforced
        /// </summary>
        [EnumMember(Value = "NOT_EXEMPT")]
        NOT_EXEMPT,

        /// <summary>
        /// The listings submission was accepted for processing.
        /// </summary>
        [EnumMember(Value = "ACCEPTED")]
        ACCEPTED,

        /// <summary>
        /// The listings submission was not valid and was not accepted for processing.
        /// </summary>
        [EnumMember(Value = "INVALID")]
        INVALID,

        /// <summary>
        /// The listings submission was valid. Only returned when the `mode` is `VALIDATION_PREVIEW`.
        /// </summary>
        [EnumMember(Value = "VALID")]
        VALID,
    }
}
