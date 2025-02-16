namespace AmznSellingPartner.Clients.VendorDirectFulfillmentTransactions.VendorDirectFulfillmentTransactions20211228
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
        /// An array of individual error objects containing error details.
        /// </summary>
        [JsonProperty("errors")]
        [IsRequired]
        public List<Error> Errors { get; set; }
    }
}
