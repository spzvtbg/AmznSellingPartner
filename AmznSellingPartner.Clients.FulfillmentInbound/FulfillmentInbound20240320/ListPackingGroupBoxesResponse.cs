namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The `listPackingGroupBoxes` response.
	/// </summary>
	public class ListPackingGroupBoxesResponse : BaseClass
	{
		/// <summary>
		/// Provides the information about the list of boxes in the packing group.
		/// </summary>
		[JsonProperty("boxes")]
		[IsRequired]
		public List<Box> Boxes { get; set; }

		[JsonProperty("pagination")]
		public Pagination Pagination { get; set; }
	}
}
