namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Summary information about a placement option.
	/// </summary>
	public class PlacementOptionSummary : BaseClass
	{
		/// <summary>
		/// The identifier of a placement option. A placement option represents the shipment splits and destinations
		/// of SKUs.
		/// </summary>
		[IsRequired]
		[Pattern("^[a-zA-Z0-9-]*")]
		[MinLength(38)]
		[MaxLength(38)]
		[JsonProperty("placementOptionId")]
		public string PlacementOptionId { get; set; }

		/// <summary>
		/// The status of a placement option. Possible values: `OFFERED`, `ACCEPTED`.
		/// </summary>
		[IsRequired]
		[MinLength(1)]
		[MaxLength(1024)]
		[JsonProperty("status")]
		public string Status { get; set; }
	}
}
