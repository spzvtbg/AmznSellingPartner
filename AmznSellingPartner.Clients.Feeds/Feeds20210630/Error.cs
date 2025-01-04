namespace AmznSellingPartner.Clients.Feeds.Feeds20210630
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// An error response returned when the request is unsuccessful.
	/// </summary>
	public class Error : BaseClass
	{
		/// <summary>
		/// An error code that identifies the type of error that occurred.
		/// </summary>
		[JsonProperty("code")]
		[IsRequired]
		public string Code { get; set; } 

		/// <summary>
		/// A message that describes the error condition.
		/// </summary>
		[JsonProperty("message")]
		[IsRequired]
		public string Message { get; set; } 

		/// <summary>
		/// Additional details that can help the caller understand or fix the issue.
		/// </summary>
		[JsonProperty("details")]
		public string Details { get; set; } 
	}
}
