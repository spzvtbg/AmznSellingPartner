namespace AmznSellingPartner.Clients.Invoices.InvoicesApiModel20240619
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The error response that is returned when the request is unsuccessful
	/// </summary>
	public class Error : BaseClass
	{
		/// <summary>
		/// An error code that identifies the type of error that occurred
		/// </summary>
		[IsRequired]
		[JsonProperty("code")]
		public string Code { get; set; }

		/// <summary>
		/// Additional details that can help the caller understand or fix the issue
		/// </summary>
		[JsonProperty("details")]
		public string Details { get; set; }

		/// <summary>
		/// A message that describes the error condition
		/// </summary>
		[IsRequired]
		[JsonProperty("message")]
		public string Message { get; set; }
	}
}
