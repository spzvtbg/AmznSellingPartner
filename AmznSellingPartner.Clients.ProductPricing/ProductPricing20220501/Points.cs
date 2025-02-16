namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
    using Newtonsoft.Json;

    /// <summary>
    /// The number of Amazon Points that are offered with the purchase of an item and the monetary
    /// value of these points.
    /// </summary>
    public class Points : BaseClass
    {
        /// <summary>
        /// The number of Amazon Points.
        /// </summary>
        [JsonProperty("pointsNumber")]
        public int PointsNumber { get; set; }

        /// <summary>
        /// The monetary value of the Amazon Points.
        /// </summary>
        [JsonProperty("pointsMonetaryValue")]
        public MoneyType PointsMonetaryValue { get; set; }
    }
}
