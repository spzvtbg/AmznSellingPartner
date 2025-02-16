namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Unit
    {
        /// <summary>
        /// The item is measured in ounces.
        /// </summary>
        [EnumMember(Value = "OUNCES")]
        OUNCES,

        /// <summary>
        /// The item is measured in pounds.
        /// </summary>
        [EnumMember(Value = "POUNDS")]
        POUNDS,

        /// <summary>
        /// The item is measured in kilograms.
        /// </summary>
        [EnumMember(Value = "KILOGRAMS")]
        KILOGRAMS,

        /// <summary>
        /// The item is measured in grams.
        /// </summary>
        [EnumMember(Value = "GRAMS")]
        GRAMS,

        /// <summary>
        /// The item is measured in milligrams.
        /// </summary>
        [EnumMember(Value = "MILLIGRAMS")]
        MILLIGRAMS,

        /// <summary>
        /// The item is measured in inches.
        /// </summary>
        [EnumMember(Value = "INCHES")]
        INCHES,

        /// <summary>
        /// The item is measured in feet.
        /// </summary>
        [EnumMember(Value = "FEET")]
        FEET,

        /// <summary>
        /// The item is measured in meters.
        /// </summary>
        [EnumMember(Value = "METERS")]
        METERS,

        /// <summary>
        /// The item is measured in centimeters.
        /// </summary>
        [EnumMember(Value = "CENTIMETERS")]
        CENTIMETERS,

        /// <summary>
        /// The item is measured in millimeters.
        /// </summary>
        [EnumMember(Value = "MILLIMETERS")]
        MILLIMETERS,

        /// <summary>
        /// The item is measured in square meters.
        /// </summary>
        [EnumMember(Value = "SQUARE_METERS")]
        SQUARE_METERS,

        /// <summary>
        /// The item is measured in square centimeters.
        /// </summary>
        [EnumMember(Value = "SQUARE_CENTIMETERS")]
        SQUARE_CENTIMETERS,

        /// <summary>
        /// The item is measured in square feet.
        /// </summary>
        [EnumMember(Value = "SQUARE_FEET")]
        SQUARE_FEET,

        /// <summary>
        /// The item is measured in square inches.
        /// </summary>
        [EnumMember(Value = "SQUARE_INCHES")]
        SQUARE_INCHES,

        /// <summary>
        /// The item is measured in gallons.
        /// </summary>
        [EnumMember(Value = "GALLONS")]
        GALLONS,

        /// <summary>
        /// The item is measured in pints.
        /// </summary>
        [EnumMember(Value = "PINTS")]
        PINTS,

        /// <summary>
        /// The item is measured in quarts.
        /// </summary>
        [EnumMember(Value = "QUARTS")]
        QUARTS,

        /// <summary>
        /// The item is measured in fluid ounces.
        /// </summary>
        [EnumMember(Value = "FLUID_OUNCES")]
        FLUID_OUNCES,

        /// <summary>
        /// The item is measured in liters.
        /// </summary>
        [EnumMember(Value = "LITERS")]
        LITERS,

        /// <summary>
        /// The item is measured in cubic meters.
        /// </summary>
        [EnumMember(Value = "CUBIC_METERS")]
        CUBIC_METERS,

        /// <summary>
        /// The item is measured in cubic feet.
        /// </summary>
        [EnumMember(Value = "CUBIC_FEET")]
        CUBIC_FEET,

        /// <summary>
        /// The item is measured in cubic inches.
        /// </summary>
        [EnumMember(Value = "CUBIC_INCHES")]
        CUBIC_INCHES,

        /// <summary>
        /// The item is measured in cubic centimeters.
        /// </summary>
        [EnumMember(Value = "CUBIC_CENTIMETERS")]
        CUBIC_CENTIMETERS,

        /// <summary>
        /// The item is measured by count.
        /// </summary>
        [EnumMember(Value = "COUNT")]
        COUNT,
    }
}
