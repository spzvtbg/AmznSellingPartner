namespace AmznSellingPartner.Clients.ListingsItems.ListingsItems20210801
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Response containing the results of a submission to the Selling Partner API for Listings Items
	/// </summary>
	public class ListingsItemSubmissionResponse : BaseClass
	{
		/// <summary>
		/// A selling partner provided identifier for an Amazon listing
		/// </summary>
		[IsRequired]
		[JsonProperty("sku")]
		public string Sku { get; set; }

		/// <summary>
		/// The status of the listings item submission
		/// </summary>
		[IsRequired]
		[JsonProperty("status")]
		public Status Status { get; set; }

		/// <summary>
		/// The unique identifier of the listings item submission
		/// </summary>
		[IsRequired]
		[JsonProperty("submissionId")]
		public string SubmissionId { get; set; }

		/// <summary>
		/// Listings item issues related to the listings item submission
		/// </summary>
		[JsonProperty("issues")]
		public List<Issue> Issues { get; set; }

		/// <summary>
		/// Identity attributes associated with the item in the Amazon catalog, such as the ASIN
		/// </summary>
		[JsonProperty("identifiers")]
		public ItemIdentifiers Identifiers { get; set; }
	}
}
