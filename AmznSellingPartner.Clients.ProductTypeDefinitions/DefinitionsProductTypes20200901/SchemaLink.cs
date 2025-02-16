namespace AmznSellingPartner.Clients.ProductTypeDefinitions.DefinitionsProductTypes20200901
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    public class SchemaLink : BaseClass
    {
        /// <summary>
        /// Link to retrieve the schema.
        /// </summary>
        [JsonProperty("link")]
        [IsRequired]
        public Link Link { get; set; }

        /// <summary>
        /// Checksum hash of the schema (Base64 MD5). Can be used to verify schema contents, identify changes
        /// between schema versions, and for caching.
        /// </summary>
        [JsonProperty("checksum")]
        [IsRequired]
        public string Checksum { get; set; }
    }
}
