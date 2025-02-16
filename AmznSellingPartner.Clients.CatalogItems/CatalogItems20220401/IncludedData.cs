namespace AmznSellingPartner.Clients.CatalogItems.CatalogItems20220401
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum IncludedData
    {
        /// <summary>
        /// A JSON object containing structured item attribute data keyed by attribute name. Catalog item
        /// attributes conform to the related Amazon product type definitions available in the Selling
        /// Partner API for Product Type Definitions.
        /// </summary>
        [EnumMember(Value = "attributes")]
        Attributes,

        /// <summary>
        /// Classifications (browse nodes) for an item in the Amazon catalog.
        /// </summary>
        [EnumMember(Value = "classifications")]
        Classifications,

        /// <summary>
        /// Dimensions for an item in the Amazon catalog.
        /// </summary>
        [EnumMember(Value = "dimensions")]
        Dimensions,

        /// <summary>
        /// Identifiers associated with the item in the Amazon catalog, such as UPC and EAN identifier
        /// s.
        /// </summary>
        [EnumMember(Value = "identifiers")]
        Identifiers,

        /// <summary>
        /// Images for an item in the Amazon catalog.
        /// </summary>
        [EnumMember(Value = "images")]
        Images,

        /// <summary>
        /// Product types associated with the Amazon catalog item.
        /// </summary>
        [EnumMember(Value = "productTypes")]
        ProductTypes,

        /// <summary>
        /// Relationship details of an Amazon catalog item (for example, variations).
        /// </summary>
        [EnumMember(Value = "relationships")]
        Relationships,

        /// <summary>
        /// Sales ranks of an Amazon catalog item.
        /// </summary>
        [EnumMember(Value = "salesRanks")]
        SalesRanks,

        /// <summary>
        /// Summary details of an Amazon catalog item. Refer to the "attributes" of an Amazon catalog item
        /// for more details.
        /// </summary>
        [EnumMember(Value = "summaries")]
        Summaries,

        /// <summary>
        /// Vendor details associated with an Amazon catalog item. Vendor details are available to vendors
        /// only.
        /// </summary>
        [EnumMember(Value = "vendorDetails")]
        VendorDetails,
    }
}
