namespace AmznSellingPartner.Clients.Tokens.Tokens20210301
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The request schema for the createRestrictedDataToken operation
	/// </summary>
	public class CreateRestrictedDataTokenRequest : BaseClass
	{
		/// <summary>
		/// The application ID for the target application to which access is being delegated
		/// </summary>
		[JsonProperty("targetApplication")]
		public string TargetApplication { get; set; }

		/// <summary>
		/// A list of restricted resources
		/// Maximum: 50
		/// </summary>
		[IsRequired]
		[JsonProperty("restrictedResources")]
		public List<RestrictedResource> RestrictedResources { get; set; }
	}
}
