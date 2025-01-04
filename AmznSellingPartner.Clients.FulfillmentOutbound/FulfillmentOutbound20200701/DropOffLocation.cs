namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The preferred location to leave packages at the destination address.
	/// </summary>
	public class DropOffLocation : BaseClass
	{
		/// <summary>
		/// Specifies the preferred location to leave the package at the destination address.
		/// </summary>
		[JsonProperty("type")]
		[IsRequired]
		public Type Type { get; set; }

		/// <summary>
		/// Additional information about the drop-off location that can vary depending on the type of drop-off location
		/// specified in the `type` field. If the `type` is set to `FALLBACK_NEIGHBOR_DELIVERY`, the `attributes`
		/// object should include the exact keys `neighborName` and `houseNumber` to provide the name and house number
		/// of the designated neighbor.
		/// </summary>
		[JsonProperty("attributes")]
		public Attributes Attributes { get; set; }
	}
}
