namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// A standard headline and body text with an image on the side.
    /// </summary>
    public class StandardSingleSideImageModule : BaseClass
    {
        [JsonProperty("imagePositionType")]
        [IsRequired]
        public PositionType ImagePositionType { get; set; }

        [JsonProperty("block")]
        public StandardImageTextBlock Block { get; set; }
    }
}
