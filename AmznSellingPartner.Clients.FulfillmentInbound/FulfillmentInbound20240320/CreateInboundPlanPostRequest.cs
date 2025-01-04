namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpPost("/inbound/fba/2024-03-20/inboundPlans")]
	public class CreateInboundPlanPostRequest : BaseHttpRequest
	{
		/// <summary>
		/// The body of the request to `createInboundPlan`.
		/// </summary>
		[InBody("body")]
		[IsRequired]
		public CreateInboundPlanRequest Body { get; set; }
	}
}
