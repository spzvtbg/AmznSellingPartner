namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    using System.Collections.Generic;

    /// <summary>
    /// The `setPackingInformation` request.
    /// </summary>
    public class SetPackingInformationRequest : BaseClass
    {
        /// <summary>
        /// List of packing information for the inbound plan.
        /// </summary>
        [JsonProperty("packageGroupings")]
        [IsRequired]
        [MinItems(1)]
        public List<PackageGroupingInput> PackageGroupings { get; set; }
    }
}
