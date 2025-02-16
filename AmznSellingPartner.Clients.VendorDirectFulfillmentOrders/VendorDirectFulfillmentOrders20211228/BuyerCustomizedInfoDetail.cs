namespace AmznSellingPartner.Clients.VendorDirectFulfillmentOrders.VendorDirectFulfillmentOrders20211228
{
    using Newtonsoft.Json;

    /// <summary>
    /// The details of the products the vendor has configured as customizable.
    /// </summary>
    public class BuyerCustomizedInfoDetail : BaseClass
    {
        /// <summary>
        /// A [Base 64](https://datatracker.ietf.org/doc/html/rfc4648#section-4) encoded URL using the
        /// UTF-8 character set. The URL provides the location of the zip file that specifies the types
        /// of customizations or configurations allowed by the vendor, along with types and ranges for
        /// the attributes of their products.
        /// </summary>
        [JsonProperty("customizedUrl")]
        public string CustomizedUrl { get; set; }
    }
}
