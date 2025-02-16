namespace AmznSellingPartner.Clients.ProductFees.ProductFeesV0
{
    using Newtonsoft.Json;

    public class Points : BaseClass
    {
        [JsonProperty("PointsNumber")]
        public int PointsNumber { get; set; }

        [JsonProperty("PointsMonetaryValue")]
        public MoneyType PointsMonetaryValue { get; set; }
    }
}
