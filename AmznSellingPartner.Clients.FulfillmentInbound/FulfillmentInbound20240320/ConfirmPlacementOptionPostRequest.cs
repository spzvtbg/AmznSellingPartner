namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpPost("/inbound/fba/2024-03-20/inboundPlans/{inboundPlanId}/placementOptions/{placementOptionId}/confirmation")]
	public class ConfirmPlacementOptionPostRequest : BaseHttpRequest
	{
		/// <summary>
		/// Identifier of an inbound plan.
		/// </summary>
		[InPath("inboundPlanId")]
		[IsRequired]
		[MinLength(38)]
		[MaxLength(38)]
		[Pattern("^[a-zA-Z0-9-]*")]
		[JsonProperty("inboundPlanId")]
		public string InboundPlanId { get; set; }

		/// <summary>
		/// The identifier of a placement option. A placement option represents the shipment splits and destinations
		/// of SKUs.
		/// </summary>
		[InPath("placementOptionId")]
		[IsRequired]
		[MinLength(38)]
		[MaxLength(38)]
		[Pattern("^[a-zA-Z0-9-]*")]
		[JsonProperty("placementOptionId")]
		public string PlacementOptionId { get; set; }
	}
}
