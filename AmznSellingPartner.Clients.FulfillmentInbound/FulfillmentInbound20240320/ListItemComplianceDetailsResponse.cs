namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The `listItemComplianceDetails` response
	/// </summary>
	public class ListItemComplianceDetailsResponse : BaseClass
	{
		/// <summary>
		/// List of compliance details
		/// </summary>
		[JsonProperty("complianceDetails")]
		public List<ComplianceDetail> ComplianceDetails { get; set; }
	}
}
