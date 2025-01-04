namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpPost("/inbound/fba/2024-03-20/inboundPlans/{inboundPlanId}/transportationOptions/confirmation")]
	public class ConfirmTransportationOptionsPostRequest : BaseHttpRequest
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
		/// The body of the request to `confirmTransportationOptions`.
		/// </summary>
		[InBody("body")]
		[IsRequired]
		public ConfirmTransportationOptionsRequest Body { get; set; }
	}
}
