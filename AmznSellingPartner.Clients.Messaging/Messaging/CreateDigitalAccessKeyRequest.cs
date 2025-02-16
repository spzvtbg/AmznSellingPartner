namespace AmznSellingPartner.Clients.Messaging.Messaging
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    using System.Collections.Generic;

    /// <summary>
    /// The request schema for the `createDigitalAccessKey` operation.
    /// </summary>
    public class CreateDigitalAccessKeyRequest : BaseClass
    {
        /// <summary>
        /// The text that is sent to the buyer. Only links that are related to the digital access key are
        /// allowed. Do not include HTML or email addresses. The text must be written in the buyer's preferred
        /// language, which you can retrieve from the `GetAttributes` operation.
        /// </summary>
        [JsonProperty("text")]
        [MinLength(1)]
        [MaxLength(400)]
        public string Text { get; set; }

        /// <summary>
        /// Attachments that you want to include in the message to the buyer.
        /// </summary>
        [JsonProperty("attachments")]
        [MaxLength(5)]
        public List<Attachment> Attachments { get; set; }
    }
}
