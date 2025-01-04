namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpPost("/inbound/fba/2024-03-20/inboundPlans/{inboundPlanId}/packingInformation")]
	public class SetPackingInformationPostRequest : BaseHttpRequest
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
		/// The body of the request to `setPackingInformation`.
		/// </summary>
		[InBody("body")]
		[IsRequired]
		public SetPackingInformationRequest Body { get; set; }
	}
}
