namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The `createInboundPlan` response.
	/// </summary>
	public class CreateInboundPlanResponse : BaseClass
	{
		/// <summary>
		/// Identifier of an inbound plan.
		/// </summary>
		[JsonProperty("inboundPlanId")]
		[IsRequired]
		[Pattern("^[a-zA-Z0-9-]*")]
		[MinLength(38)]
		[MaxLength(38)]
		public string InboundPlanId { get; set; } 

		/// <summary>
		/// UUID for the given operation.
		/// </summary>
		[JsonProperty("operationId")]
		[IsRequired]
		[Pattern("^[a-zA-Z0-9-]*")]
		[MinLength(36)]
		[MaxLength(38)]
		public string OperationId { get; set; } 
	}
}
