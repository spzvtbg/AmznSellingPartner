namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// The response schema for the `createContainerLabel` operation.
    /// </summary>
    public class CreateContainerLabelResponse : BaseClass
    {
        /// <summary>
        /// The label data for the container label.
        /// </summary>
        [JsonProperty("containerLabel")]
        [IsRequired]
        public ContainerLabel ContainerLabel { get; set; }
    }
}
