namespace AmznSellingPartner.Clients.ProductTypeDefinitions.DefinitionsProductTypes20200901
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    using System.Collections.Generic;

    /// <summary>
    /// A list of error responses returned when a request is unsuccessful.
    /// </summary>
    public class ErrorList : BaseClass
    {
        [JsonProperty("errors")]
        [IsRequired]
        public List<Error> Errors { get; set; }
    }
}
