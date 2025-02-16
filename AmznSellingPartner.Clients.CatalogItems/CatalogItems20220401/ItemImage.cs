namespace AmznSellingPartner.Clients.CatalogItems.CatalogItems20220401
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// Image for an item in the Amazon catalog.
    /// </summary>
    public class ItemImage : BaseClass
    {
        /// <summary>
        /// Variant of the image, such as `MAIN` or `PT01`.
        /// </summary>
        [JsonProperty("variant")]
        [IsRequired]
        public Variant Variant { get; set; }

        /// <summary>
        /// Link, or URL, for the image.
        /// </summary>
        [JsonProperty("link")]
        [IsRequired]
        public string Link { get; set; }

        /// <summary>
        /// Height of the image in pixels.
        /// </summary>
        [JsonProperty("height")]
        [IsRequired]
        public int Height { get; set; }

        /// <summary>
        /// Width of the image in pixels.
        /// </summary>
        [JsonProperty("width")]
        [IsRequired]
        public int Width { get; set; }
    }
}
