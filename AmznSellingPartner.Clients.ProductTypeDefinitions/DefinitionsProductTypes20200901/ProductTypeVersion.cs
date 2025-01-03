namespace AmznSellingPartner.Clients.ProductTypeDefinitions.DefinitionsProductTypes20200901
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The version details for an Amazon product type.
	/// </summary>
	public class ProductTypeVersion : BaseClass
	{
		/// <summary>
		/// Version identifier.
		/// </summary>
		[IsRequired]
		[JsonProperty("version")]
		public string Version { get; set; }

		/// <summary>
		/// When true, the version indicated by the version identifier is the latest available for the Amazon product
		/// type.
		/// </summary>
		[IsRequired]
		[JsonProperty("latest")]
		public bool Latest { get; set; }

		/// <summary>
		/// When true, the version indicated by the version identifier is the prerelease (release candidate) for
		/// the Amazon product type.
		/// </summary>
		[JsonProperty("releaseCandidate")]
		public bool ReleaseCandidate { get; set; }
	}
}
