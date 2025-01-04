namespace AmznSellingPartner.Clients.FbaInboundEligibility.FbaInbound
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The response object which contains the ASIN, marketplaceId if required, eligibility program, the eligibility
	/// status (boolean), and a list of ineligibility reason codes.
	/// </summary>
	public class ItemEligibilityPreview : BaseClass
	{
		/// <summary>
		/// The ASIN for which eligibility was determined.
		/// </summary>
		[JsonProperty("asin")]
		[IsRequired]
		public string Asin { get; set; }

		/// <summary>
		/// The marketplace for which eligibility was determined.
		/// </summary>
		[JsonProperty("marketplaceId")]
		public string MarketplaceId { get; set; }

		/// <summary>
		/// The program for which eligibility was determined.
		/// </summary>
		[JsonProperty("program")]
		[IsRequired]
		public Program Program { get; set; }

		/// <summary>
		/// Indicates if the item is eligible for the program.
		/// </summary>
		[JsonProperty("isEligibleForProgram")]
		[IsRequired]
		public bool IsEligibleForProgram { get; set; }

		/// <summary>
		/// Potential Ineligibility Reason Codes.
		/// </summary>
		[JsonProperty("ineligibilityReasonList")]
		public List<IneligibilityReasonList> IneligibilityReasonList { get; set; }
	}
}
