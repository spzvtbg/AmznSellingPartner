namespace AmznSellingPartner.Clients.ApplicationIntegrations.AppIntegrations20240401
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// A list of error responses returned when a request is unsuccessful.
	/// </summary>
	public class ErrorList : BaseClass
	{
		/// <summary>
		/// Error response returned when the request is unsuccessful.
		/// </summary>
		[IsRequired]
		[JsonProperty("errors")]
		public List<Error> Errors { get; set; }
	}
}
