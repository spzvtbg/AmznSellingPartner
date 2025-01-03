namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// A problem with additional properties persisted to an operation.
	/// </summary>
	public class OperationProblem : BaseClass
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

		/// <summary>
		/// The severity of the problem. Possible values: `WARNING`, `ERROR`.
		/// </summary>
		[IsRequired]
		[MinLength(1)]
		[MaxLength(1024)]
		[JsonProperty("severity")]
		public string Severity { get; set; }
	}
}
