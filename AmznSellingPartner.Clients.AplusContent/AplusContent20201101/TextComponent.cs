namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// Rich text content.
    /// </summary>
    public class TextComponent : BaseClass
    {
        /// <summary>
        /// The actual plain text.
        /// </summary>
        [JsonProperty("value")]
        [IsRequired]
        [MinLength(1)]
        [MaxLength(10000)]
        public string Value { get; set; }

        [JsonProperty("decoratorSet")]
        public DecoratorSet DecoratorSet { get; set; }
    }
}
