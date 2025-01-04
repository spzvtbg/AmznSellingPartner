namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Error response returned when the request is unsuccessful.
	/// </summary>
	public class Error : BaseClass
	{
		/// <summary>
		/// The code that identifies the type of error condition.
		/// </summary>
		[JsonProperty("code")]
		[IsRequired]
		[MinLength(1)]
		public string Code { get; set; }

		/// <summary>
		/// A human readable description of the error condition.
		/// </summary>
		[JsonProperty("message")]
		[IsRequired]
		[MinLength(1)]
		public string Message { get; set; }

		/// <summary>
		/// Additional information, if available, to clarify the error condition.
		/// </summary>
		[JsonProperty("details")]
		[MinLength(1)]
		public string Details { get; set; }
	}
}
