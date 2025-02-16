namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// The request for the getFulfillmentOrder operation.
    /// </summary>
    public class GetFulfillmentOrderResult : BaseClass
    {
        [JsonProperty("fulfillmentOrder")]
        [IsRequired]
        public FulfillmentOrder FulfillmentOrder { get; set; }

        [JsonProperty("fulfillmentOrderItems")]
        [IsRequired]
        public FulfillmentOrderItemList FulfillmentOrderItems { get; set; }

        [JsonProperty("fulfillmentShipments")]
        public FulfillmentShipmentList FulfillmentShipments { get; set; }

        [JsonProperty("returnItems")]
        [IsRequired]
        public ReturnItemList ReturnItems { get; set; }

        [JsonProperty("returnAuthorizations")]
        [IsRequired]
        public ReturnAuthorizationList ReturnAuthorizations { get; set; }

        [JsonProperty("paymentInformation")]
        public PaymentInformationList PaymentInformation { get; set; }
    }
}
