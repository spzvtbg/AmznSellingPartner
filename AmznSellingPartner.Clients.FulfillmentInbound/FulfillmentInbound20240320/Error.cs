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
		[JsonProperty("code")]
		[IsRequired]
		[MinLength(1)]
		[MaxLength(256)]
		public string Code { get; set; }

		/// <summary>
		/// Additional details that can help the caller understand or fix the issue.
		/// </summary>
		[JsonProperty("details")]
		[MinLength(0)]
		[MaxLength(8192)]
		public string Details { get; set; }

		/// <summary>
		/// A message that describes the error condition.
		/// </summary>
		[JsonProperty("message")]
		[IsRequired]
		[MinLength(1)]
		[MaxLength(2048)]
		public string Message { get; set; }
	}
}
