namespace AmznSellingPartner.Clients.ProductFees.ProductFeesV0
{
	using Newtonsoft.Json;

	/// <summary>
	/// An item identifier and the estimated fees for the item
	/// </summary>
	public class FeesEstimateResult : BaseClass
	{
		/// <summary>
		/// The status of the fee request
		/// Possible values: Success, ClientError, ServiceError
		/// </summary>
		[JsonProperty("Status")]
		public string Status { get; set; }

		/// <summary>
		/// Information used to identify a fees estimate request
		/// </summary>
		[JsonProperty("FeesEstimateIdentifier")]
		public FeesEstimateIdentifier FeesEstimateIdentifier { get; set; }

		/// <summary>
		/// The total estimated fees for an item and a list of details
		/// </summary>
		[JsonProperty("FeesEstimate")]
		public FeesEstimate FeesEstimate { get; set; }

		/// <summary>
		/// An error object with a type, code, and message
		/// </summary>
		[JsonProperty("Error")]
		public FeesEstimateError Error { get; set; }
	}
}
