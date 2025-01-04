namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpPut("/inbound/fba/2024-03-20/inboundPlans/{inboundPlanId}/name")]
	public class UpdateInboundPlanNamePutRequest : BaseHttpRequest
	{
		/// <summary>
		/// Identifier of an inbound plan.
		/// </summary>
		[InPath("inboundPlanId")]
		[IsRequired]
		[MinLength(38)]
		[MaxLength(38)]
		[Pattern("^[a-zA-Z0-9-]*")]
		public string InboundPlanId { get; set; } 

		/// <summary>
		/// The body of the request to `updateInboundPlanName`.
		/// </summary>
		[InBody("body")]
		[IsRequired]
		public UpdateInboundPlanNameRequest Body { get; set; } 
	}
}
