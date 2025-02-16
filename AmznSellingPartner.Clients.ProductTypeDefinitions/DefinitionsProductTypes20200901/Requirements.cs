namespace AmznSellingPartner.Clients.ProductTypeDefinitions.DefinitionsProductTypes20200901
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Requirements
    {
        /// <summary>
        /// Request schema containing product facts and sales terms.
        /// </summary>
        [EnumMember(Value = "LISTING")]
        LISTING,

        /// <summary>
        /// Request schema containing product facts only.
        /// </summary>
        [EnumMember(Value = "LISTING_PRODUCT_ONLY")]
        LISTING_PRODUCT_ONLY,

        /// <summary>
        /// Request schema containing sales terms only.
        /// </summary>
        [EnumMember(Value = "LISTING_OFFER_ONLY")]
        LISTING_OFFER_ONLY,
    }
}
