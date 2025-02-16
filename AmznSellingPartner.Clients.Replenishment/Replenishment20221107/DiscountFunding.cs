namespace AmznSellingPartner.Clients.Replenishment.Replenishment20221107
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    using System.Collections.Generic;

    /// <summary>
    /// The discount funding on the offer.
    /// </summary>
    public class DiscountFunding : BaseClass
    {
        /// <summary>
        /// Filters the results to only include offers with the percentage specified.
        /// </summary>
        [JsonProperty("percentage")]
        [MinItems(1)]
        [MaxItems(10)]
        [UniqueItems]
        public List<long> Percentage { get; set; }
    }
}
