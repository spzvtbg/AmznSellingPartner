namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Error response returned when the request is unsuccessful
	/// </summary>
	public class Error : BaseClass
	{
		/// <summary>
		/// The code that identifies the type of error condition
		/// </summary>
		[IsRequired]
		[MinLength(1)]
		[JsonProperty("code")]
		public string Code { get; set; }

		/// <summary>
		/// A human readable description of the error condition
		/// </summary>
		[IsRequired]
		[MinLength(1)]
		[JsonProperty("message")]
		public string Message { get; set; }

		/// <summary>
		/// Additional information, if available, to clarify the error condition
		/// </summary>
		[MinLength(1)]
		[JsonProperty("details")]
		public string Details { get; set; }
	}
}
