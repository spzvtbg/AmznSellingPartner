namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The request for the getFulfillmentOrder operation
	/// </summary>
	public class GetFulfillmentOrderResult : BaseClass
	{
		[IsRequired]
		[JsonProperty("fulfillmentOrder")]
		public FulfillmentOrder FulfillmentOrder { get; set; }

		[IsRequired]
		[JsonProperty("fulfillmentOrderItems")]
		public FulfillmentOrderItemList FulfillmentOrderItems { get; set; }

		[JsonProperty("fulfillmentShipments")]
		public FulfillmentShipmentList FulfillmentShipments { get; set; }

		[IsRequired]
		[JsonProperty("returnItems")]
		public ReturnItemList ReturnItems { get; set; }

		[IsRequired]
		[JsonProperty("returnAuthorizations")]
		public ReturnAuthorizationList ReturnAuthorizations { get; set; }

		[JsonProperty("paymentInformation")]
		public PaymentInformationList PaymentInformation { get; set; }
	}
}
