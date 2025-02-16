namespace AmznSellingPartner.Clients.Messaging.Messaging
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    using System.Collections.Generic;

    /// <summary>
    /// The request schema for the createAmazonMotors operation.
    /// </summary>
    public class CreateAmazonMotorsRequest : BaseClass
    {
        /// <summary>
        /// Attachments to include in the message to the buyer. If any text is included in the attachment,
        /// the text must be written in the buyer's language of preference, which can be retrieved from
        /// the GetAttributes operation.
        /// </summary>
        [JsonProperty("attachments")]
        [MaxLength(5)]
        public List<Attachment> Attachments { get; set; }
    }
}
