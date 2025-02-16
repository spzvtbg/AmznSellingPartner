namespace AmznSellingPartner.Clients.Services.Services
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// Information about the seller of the service job.
    /// </summary>
    public class Seller : BaseClass
    {
        /// <summary>
        /// The identifier of the seller of the service job.
        /// </summary>
        [JsonProperty("sellerId")]
        [Pattern("^[A-Z0-9]*")]
        public string SellerId { get; set; }
    }
}
