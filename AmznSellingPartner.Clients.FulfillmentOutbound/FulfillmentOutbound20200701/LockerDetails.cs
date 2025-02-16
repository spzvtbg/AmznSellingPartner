namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
    using Newtonsoft.Json;

    /// <summary>
    /// The locker details, which you can use to access the locker delivery box.
    /// </summary>
    public class LockerDetails : BaseClass
    {
        /// <summary>
        /// Indicates the locker number
        /// </summary>
        [JsonProperty("lockerNumber")]
        public string LockerNumber { get; set; }

        /// <summary>
        /// Indicates the locker access code
        /// </summary>
        [JsonProperty("lockerAccessCode")]
        public string LockerAccessCode { get; set; }
    }
}
