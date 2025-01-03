namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The `setPackingInformation` request
	/// </summary>
	public class SetPackingInformationRequest : BaseClass
	{
		/// <summary>
		/// List of packing information for the inbound plan
		/// </summary>
		[IsRequired]
		[MinItems(1)]
		[JsonProperty("packageGroupings")]
		public List<PackageGroupingInput> PackageGroupings { get; set; }
	}
}
