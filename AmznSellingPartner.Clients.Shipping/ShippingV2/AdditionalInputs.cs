namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
    using Newtonsoft.Json;

    public class AdditionalInputs : BaseClass
    {
        [JsonProperty("")]
        public object AdditionalValue { get; set; }
    }
}
