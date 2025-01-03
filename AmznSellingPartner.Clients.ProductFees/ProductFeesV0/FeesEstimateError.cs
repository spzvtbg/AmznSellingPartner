namespace AmznSellingPartner.Clients.ProductFees.ProductFeesV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// An unexpected error occurred during this operation
	/// </summary>
	public class FeesEstimateError : BaseClass
	{
		/// <summary>
		/// An error type, identifying either the receiver or the sender as the originator of the error
		/// </summary>
		[IsRequired]
		[JsonProperty("Type")]
		public string Type { get; set; }

		/// <summary>
		/// An error code that identifies the type of error that occurred
		/// </summary>
		[IsRequired]
		[JsonProperty("Code")]
		public string Code { get; set; }

		/// <summary>
		/// A message that describes the error condition
		/// </summary>
		[IsRequired]
		[JsonProperty("Message")]
		public string Message { get; set; }

		[IsRequired]
		[JsonProperty("Detail")]
		public FeesEstimateErrorDetail Detail { get; set; }
	}
}
