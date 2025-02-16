namespace AmznSellingPartner.Clients.Services.Services
{
    using Newtonsoft.Json;

    using System.Collections.Generic;

    /// <summary>
    /// Range capacity entity where each entry has a capacity type and corresponding slots.
    /// </summary>
    public class RangeCapacity : BaseClass
    {
        /// <summary>
        /// Capacity type corresponding to the slots.
        /// </summary>
        [JsonProperty("capacityType")]
        public CapacityType CapacityType { get; set; }

        /// <summary>
        /// Array of capacity slots in range slot format.
        /// </summary>
        [JsonProperty("slots")]
        public List<RangeSlot> Slots { get; set; }
    }
}
