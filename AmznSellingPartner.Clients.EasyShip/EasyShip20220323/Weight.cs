namespace AmznSellingPartner.Clients.EasyShip.EasyShip20220323
{
    using Newtonsoft.Json;

    /// <summary>
    /// The weight of the scheduled package
    /// </summary>
    public class Weight : BaseClass
    {
        [JsonProperty("value")]
        public WeightValue Value { get; set; }

        [JsonProperty("unit")]
        public UnitOfWeight Unit { get; set; }
    }
}
