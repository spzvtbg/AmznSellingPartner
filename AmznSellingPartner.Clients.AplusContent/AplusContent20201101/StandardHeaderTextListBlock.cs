namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
    using Newtonsoft.Json;

    /// <summary>
    /// The A+ standard fixed-length list of text, with a related headline.
    /// </summary>
    public class StandardHeaderTextListBlock : BaseClass
    {
        [JsonProperty("headline")]
        public TextComponent Headline { get; set; }

        [JsonProperty("block")]
        public StandardTextListBlock Block { get; set; }
    }
}
