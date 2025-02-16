namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
    using Newtonsoft.Json;

    /// <summary>
    /// The details about the segment. The FeaturedOfferExpectedPrice API uses only the sampleLocation
    /// portion as input.
    /// </summary>
    public class SegmentDetails : BaseClass
    {
        /// <summary>
        /// The glance view weighted percentage for this segment, which is the glance views for this segment
        /// as a percentage of total glance views across all segments for the ASIN. A higher percentage
        /// indicates that more Amazon customers receive this offer as the Featured Offer.
        /// </summary>
        [JsonProperty("glanceViewWeightPercentage")]
        public double GlanceViewWeightPercentage { get; set; }

        /// <summary>
        /// The representative location that features the offer for the segment.
        /// </summary>
        [JsonProperty("sampleLocation")]
        public SampleLocation SampleLocation { get; set; }
    }
}
