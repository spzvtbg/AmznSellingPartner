namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    using System.Collections.Generic;

    /// <summary>
    /// A list of error responses returned when a request is unsuccessful.
    /// </summary>
    public class ErrorList : BaseClass
    {
        /// <summary>
        /// List of errors.
        /// </summary>
        [JsonProperty("errors")]
        [IsRequired]
        public List<Error> Errors { get; set; }
    }
}
