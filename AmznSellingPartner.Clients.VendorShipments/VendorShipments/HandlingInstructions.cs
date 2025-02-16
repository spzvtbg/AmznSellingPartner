namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum HandlingInstructions
    {
        /// <summary>
        /// A package weighing 150 pounds or less and measuring greater than 130 inches in length and girth
        /// is classified as an oversized package.
        /// </summary>
        [EnumMember(Value = "Oversized")]
        Oversized,

        /// <summary>
        /// A package containing easily breakable items.
        /// </summary>
        [EnumMember(Value = "Fragile")]
        Fragile,

        /// <summary>
        /// A package containing edible items.
        /// </summary>
        [EnumMember(Value = "Food")]
        Food,

        /// <summary>
        /// A package containing fragile or dangerous items.
        /// </summary>
        [EnumMember(Value = "HandleWithCare")]
        HandleWithCare,
    }
}
