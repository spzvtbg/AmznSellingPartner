namespace AmznSellingPartner.Clients.Sellers.Sellers
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Detailed information that is specific to a seller in a marketplace.
	/// </summary>
	public class Participation : BaseClass
	{
		/// <summary>
		/// If true, the seller participates in the marketplace.
		/// </summary>
		[JsonProperty("isParticipating")]
		[IsRequired]
		public bool IsParticipating { get; set; }

		/// <summary>
		/// If true, the seller has suspended listings.
		/// </summary>
		[JsonProperty("hasSuspendedListings")]
		[IsRequired]
		public bool HasSuspendedListings { get; set; }
	}
}
