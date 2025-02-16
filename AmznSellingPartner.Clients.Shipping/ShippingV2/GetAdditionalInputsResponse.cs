namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
    using Newtonsoft.Json;

    /// <summary>
    /// The response schema for the getAdditionalInputs operation.
    /// </summary>
    public class GetAdditionalInputsResponse : BaseClass
    {
        [JsonProperty("payload")]
        public GetAdditionalInputsResult Payload { get; set; }
    }
}
