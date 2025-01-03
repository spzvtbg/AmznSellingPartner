namespace AmznSellingPartner.Clients.Tokens.Tokens20210301
{
	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// A list of error responses returned when a request is unsuccessful
	/// </summary>
	public class ErrorList : BaseClass
	{
		[JsonProperty("errors")]
		public List<Error> Errors { get; set; }
	}
}
