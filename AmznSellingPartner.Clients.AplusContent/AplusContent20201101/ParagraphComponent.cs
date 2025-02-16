namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    using System.Collections.Generic;

    /// <summary>
    /// A list of rich text content, usually presented in a text box.
    /// </summary>
    public class ParagraphComponent : BaseClass
    {
        [JsonProperty("textList")]
        [IsRequired]
        [MinItems(1)]
        [MaxItems(100)]
        public List<TextComponent> TextList { get; set; }
    }
}
