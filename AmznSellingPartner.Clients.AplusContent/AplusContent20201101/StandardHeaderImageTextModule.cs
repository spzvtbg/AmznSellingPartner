namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
    using Newtonsoft.Json;

    /// <summary>
    /// Standard headline text, an image, and body text.
    /// </summary>
    public class StandardHeaderImageTextModule : BaseClass
    {
        [JsonProperty("headline")]
        public TextComponent Headline { get; set; }

        [JsonProperty("block")]
        public StandardImageTextBlock Block { get; set; }
    }
}
