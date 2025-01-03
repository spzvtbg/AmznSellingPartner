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
		[IsRequired]
		[JsonProperty("isParticipating")]
		public bool IsParticipating { get; set; }

		/// <summary>
		/// If true, the seller has suspended listings.
		/// </summary>
		[IsRequired]
		[JsonProperty("hasSuspendedListings")]
		public bool HasSuspendedListings { get; set; }
	}
}
