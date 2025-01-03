namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Error object containing information about what went wrong.
	/// </summary>
	public class Error : BaseClass
	{
		/// <summary>
		/// An error code that identifies the type of error that occurred.
		/// </summary>
		[IsRequired]
		[MinLength(1)]
		[MaxLength(256)]
		[JsonProperty("code")]
		public string Code { get; set; }

		/// <summary>
		/// Additional details that can help the caller understand or fix the issue.
		/// </summary>
		[MinLength(0)]
		[MaxLength(8192)]
		[JsonProperty("details")]
		public string Details { get; set; }

		/// <summary>
		/// A message that describes the error condition.
		/// </summary>
		[IsRequired]
		[MinLength(1)]
		[MaxLength(2048)]
		[JsonProperty("message")]
		public string Message { get; set; }
	}
}
