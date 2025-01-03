namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The `listInboundPlans` response.
	/// </summary>
	public class ListInboundPlansResponse : BaseClass
	{
		/// <summary>
		/// A list of inbound plans with minimal information.
		/// </summary>
		[JsonProperty("inboundPlans")]
		public List<InboundPlanSummary> InboundPlans { get; set; }

		[JsonProperty("pagination")]
		public Pagination Pagination { get; set; }
	}
}
