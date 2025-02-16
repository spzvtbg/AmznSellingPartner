namespace AmznSellingPartner.Clients.VendorInvoices.VendorInvoices
{
    using Newtonsoft.Json;

    using System.Collections.Generic;

    /// <summary>
    /// The request schema for the submitInvoices operation.
    /// </summary>
    public class SubmitInvoicesRequest : BaseClass
    {
        /// <summary>
        /// An array of Invoice objects representing the invoices or credit notes to be submitted.
        /// </summary>
        [JsonProperty("invoices")]
        public List<Invoice> Invoices { get; set; }
    }
}
