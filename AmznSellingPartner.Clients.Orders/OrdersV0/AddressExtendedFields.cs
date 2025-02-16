namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
    using Newtonsoft.Json;

    /// <summary>
    /// The container for address extended fields (such as `street name` and `street number`). Currently
    /// only available with Brazil shipping addresses.
    /// </summary>
    public class AddressExtendedFields : BaseClass
    {
        /// <summary>
        /// The street name.
        /// </summary>
        [JsonProperty("StreetName")]
        public string StreetName { get; set; }

        /// <summary>
        /// The house, building, or property number associated with the location's street address.
        /// </summary>
        [JsonProperty("StreetNumber")]
        public string StreetNumber { get; set; }

        /// <summary>
        /// The floor number/unit number in the building/private house number.
        /// </summary>
        [JsonProperty("Complement")]
        public string Complement { get; set; }

        /// <summary>
        /// The neighborhood. This value is only used in some countries (such as Brazil).
        /// </summary>
        [JsonProperty("Neighborhood")]
        public string Neighborhood { get; set; }
    }
}
