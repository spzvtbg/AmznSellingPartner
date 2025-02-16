namespace AmznSellingPartner.Clients.SupplySources.SupplySources20200701
{
    using Newtonsoft.Json;

    using System.Collections.Generic;

    /// <summary>
    /// The list of `SupplySource`s.
    /// </summary>
    public class SupplySourceList : List<SupplySourceList>
    {
        [JsonProperty("alias")]
        public SupplySourceAlias Alias { get; set; }

        [JsonProperty("supplySourceId")]
        public SupplySourceId SupplySourceId { get; set; }

        [JsonProperty("supplySourceCode")]
        public SupplySourceCode SupplySourceCode { get; set; }

        [JsonProperty("address")]
        public Address Address { get; set; }
    }
}
