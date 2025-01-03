namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Contains information about a pallet that is used in the inbound plan. The pallet is a container that
	/// holds multiple items or boxes.
	/// </summary>
	public class Pallet : BaseClass
	{
		[JsonProperty("dimensions")]
		public Dimensions Dimensions { get; set; }

		/// <summary>
		/// Primary key to uniquely identify a Package (Box or Pallet).
		/// </summary>
		[IsRequired]
		[Pattern("^[a-zA-Z0-9-]*")]
		[MinLength(38)]
		[MaxLength(38)]
		[JsonProperty("packageId")]
		public string PackageId { get; set; }

		/// <summary>
		/// The number of containers where all other properties like weight or dimensions are identical.
		/// </summary>
		[Minimum(1)]
		[Maximum(10000)]
		[JsonProperty("quantity")]
		public int Quantity { get; set; }

		[JsonProperty("stackability")]
		public Stackability Stackability { get; set; }

		[JsonProperty("weight")]
		public Weight Weight { get; set; }
	}
}
