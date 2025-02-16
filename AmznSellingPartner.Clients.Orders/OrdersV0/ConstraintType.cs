namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    /// <summary>
    /// Details the importance of the constraint present on the item
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ConstraintType
    {
        /// <summary>
        /// Item must follow the constraint to ensure order is met with buyer's delivery requirements.
        /// </summary>
        [EnumMember(Value = "MANDATORY")]
        MANDATORY,
    }
}
