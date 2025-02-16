namespace AmznSellingPartner.Clients.EasyShip.EasyShip20220323
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// Invoice number and date.
    /// </summary>
    public class InvoiceData : BaseClass
    {
        /// <summary>
        /// The invoice number.
        /// </summary>
        [JsonProperty("invoiceNumber")]
        [IsRequired]
        public String InvoiceNumber { get; set; }

        /// <summary>
        /// The date that the invoice was generated.
        /// </summary>
        [JsonProperty("invoiceDate")]
        public DateTime InvoiceDate { get; set; }
    }
}
