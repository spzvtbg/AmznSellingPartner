namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Execution errors associated with the outbound order. This field will be populated if the order failed
	/// validation.
	/// </summary>
	public class OutboundExecutionError : BaseClass
	{
		/// <summary>
		/// Failure code details for the error.
		/// </summary>
		[IsRequired]
		[JsonProperty("failureCode")]
		public string FailureCode { get; set; }

		/// <summary>
		/// Failure reasons for the error.
		/// </summary>
		[IsRequired]
		[JsonProperty("failureReasons")]
		public List<string> FailureReasons { get; set; }

		/// <summary>
		/// MSKU associated with the error.
		/// </summary>
		[JsonProperty("sku")]
		public string Sku { get; set; }
	}
}
