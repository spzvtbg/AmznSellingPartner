namespace AmznSellingPartner.Clients.Replenishment.Replenishment20221107
{
    using Newtonsoft.Json;

    using System.Collections.Generic;

    /// <summary>
    /// An object which contains details about an offer.
    /// </summary>
    public class ListOffersResponseOffer : BaseClass
    {
        /// <summary>
        /// The SKU. This property is only supported for sellers and not for vendors.
        /// </summary>
        [JsonProperty("sku")]
        public string Sku { get; set; }

        /// <summary>
        /// The Amazon Standard Identification Number (ASIN).
        /// </summary>
        [JsonProperty("asin")]
        public string Asin { get; set; }

        /// <summary>
        /// The marketplace identifier. The supported marketplaces for both sellers and vendors are US,
        /// CA, ES, UK, FR, IT, IN, DE and JP. The supported marketplaces for vendors only are BR, AU,
        /// MX, AE and NL.  Refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids)
        /// to find the identifier for the marketplace.
        /// </summary>
        [JsonProperty("marketplaceId")]
        public MarketplaceId MarketplaceId { get; set; }

        /// <summary>
        /// The offer eligibility status.
        /// </summary>
        [JsonProperty("eligibility")]
        public EligibilityStatus Eligibility { get; set; }

        [JsonProperty("offerProgramConfiguration")]
        public OfferProgramConfiguration OfferProgramConfiguration { get; set; }

        /// <summary>
        /// The replenishment program for the offer.
        /// </summary>
        [JsonProperty("programType")]
        public ProgramType ProgramType { get; set; }

        /// <summary>
        /// A list of vendor codes associated with the offer.
        /// </summary>
        [JsonProperty("vendorCodes")]
        public List<string> VendorCodes { get; set; }
    }
}
