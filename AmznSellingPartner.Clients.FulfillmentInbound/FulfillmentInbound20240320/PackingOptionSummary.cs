namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Summary information about a packing option.
	/// </summary>
	public class PackingOptionSummary : BaseClass
	{
		/// <summary>
		/// Identifier of a packing option.
		/// </summary>
		[JsonProperty("packingOptionId")]
		[IsRequired]
		[Pattern("^[a-zA-Z0-9-]*")]
		[MinLength(38)]
		[MaxLength(38)]
		public string PackingOptionId { get; set; } 

		/// <summary>
		/// The status of a packing option. Possible values: 'OFFERED', 'ACCEPTED', 'EXPIRED'.
		/// </summary>
		[JsonProperty("status")]
		[IsRequired]
		[MinLength(1)]
		[MaxLength(1024)]
		public string Status { get; set; } 
	}
}
