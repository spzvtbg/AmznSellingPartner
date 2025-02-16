namespace AmznSellingPartner.Clients.Sellers.Sellers
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum BusinessType
    {
        /// <summary>
        /// The business is registered as a charity.
        /// </summary>
        [EnumMember(Value = "CHARITY")]
        CHARITY,

        /// <summary>
        /// The business is registered as a craftsman.
        /// </summary>
        [EnumMember(Value = "CRAFTSMAN")]
        CRAFTSMAN,

        /// <summary>
        /// The business is a natural person company.
        /// </summary>
        [EnumMember(Value = "NATURAL_PERSON_COMPANY")]
        NATURAL_PERSON_COMPANY,

        /// <summary>
        /// The business is a publicly listed company.
        /// </summary>
        [EnumMember(Value = "PUBLIC_LISTED")]
        PUBLIC_LISTED,

        /// <summary>
        /// The business is a private limited company.
        /// </summary>
        [EnumMember(Value = "PRIVATE_LIMITED")]
        PRIVATE_LIMITED,

        /// <summary>
        /// The business is a sole proprietorship.
        /// </summary>
        [EnumMember(Value = "SOLE_PROPRIETORSHIP")]
        SOLE_PROPRIETORSHIP,

        /// <summary>
        /// The business is state-owned.
        /// </summary>
        [EnumMember(Value = "STATE_OWNED")]
        STATE_OWNED,

        /// <summary>
        /// The entity is not a business but an individual.
        /// </summary>
        [EnumMember(Value = "INDIVIDUAL")]
        INDIVIDUAL,
    }
}
