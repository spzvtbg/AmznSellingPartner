namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
    using Newtonsoft.Json;

    /// <summary>
    /// A standard image with several paragraphs and a bulleted list.
    /// </summary>
    public class StandardSingleImageHighlightsModule : BaseClass
    {
        [JsonProperty("image")]
        public ImageComponent Image { get; set; }

        [JsonProperty("headline")]
        public TextComponent Headline { get; set; }

        [JsonProperty("textBlock1")]
        public StandardTextBlock TextBlock1 { get; set; }

        [JsonProperty("textBlock2")]
        public StandardTextBlock TextBlock2 { get; set; }

        [JsonProperty("textBlock3")]
        public StandardTextBlock TextBlock3 { get; set; }

        [JsonProperty("bulletedListBlock")]
        public StandardHeaderTextListBlock BulletedListBlock { get; set; }
    }
}
