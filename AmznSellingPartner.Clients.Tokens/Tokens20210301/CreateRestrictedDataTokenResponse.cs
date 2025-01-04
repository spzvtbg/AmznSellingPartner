namespace AmznSellingPartner.Clients.Tokens.Tokens20210301
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the createRestrictedDataToken operation.
	/// </summary>
	public class CreateRestrictedDataTokenResponse : BaseClass
	{
		/// <summary>
		/// A Restricted Data Token (RDT). This is a short-lived access token that authorizes calls to restricted
		/// operations. Pass this value with the x-amz-access-token header when making subsequent calls to these
		/// restricted resources.
		/// </summary>
		[JsonProperty("restrictedDataToken")]
		public string RestrictedDataToken { get; set; } 

		/// <summary>
		/// The lifetime of the Restricted Data Token, in seconds.
		/// </summary>
		[JsonProperty("expiresIn")]
		public int ExpiresIn { get; set; } 
	}
}
