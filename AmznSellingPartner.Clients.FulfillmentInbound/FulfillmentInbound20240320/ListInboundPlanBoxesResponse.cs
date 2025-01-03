namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The `listInboundPlanBoxes` response.
	/// </summary>
	public class ListInboundPlanBoxesResponse : BaseClass
	{
		/// <summary>
		/// A list of boxes in an inbound plan.
		/// </summary>
		[IsRequired]
		[JsonProperty("boxes")]
		public List<Box> Boxes { get; set; }

		[JsonProperty("pagination")]
		public Pagination Pagination { get; set; }
	}
}
