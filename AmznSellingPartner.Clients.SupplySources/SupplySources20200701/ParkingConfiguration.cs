namespace AmznSellingPartner.Clients.SupplySources.SupplySources20200701
{
    using Newtonsoft.Json;

    /// <summary>
    /// The parking configuration.
    /// </summary>
    public class ParkingConfiguration : BaseClass
    {
        /// <summary>
        /// The type of cost at parking location.
        /// </summary>
        [JsonProperty("parkingCostType")]
        public ParkingCostType ParkingCostType { get; set; }

        /// <summary>
        /// The type of parking spot identification used at parking location.
        /// </summary>
        [JsonProperty("parkingSpotIdentificationType")]
        public ParkingSpotIdentificationType ParkingSpotIdentificationType { get; set; }

        /// <summary>
        /// The number of parking spots.
        /// </summary>
        [JsonProperty("numberOfParkingSpots")]
        public NonNegativeInteger NumberOfParkingSpots { get; set; }
    }
}
