namespace AmznSellingPartner.Clients.Finances.Transfers20240601
{
    using Newtonsoft.Json;

    /// <summary>
    /// The response schema for the `getPaymentMethods` operation.
    /// </summary>
    public class GetPaymentMethodsResponse : BaseClass
    {
        [JsonProperty("paymentMethods")]
        public PaymentMethodList PaymentMethods { get; set; }
    }
}
