namespace AmznSellingPartner.Clients.ListingsItems.ListingsItems20210801
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// This field provides information about the enforcement actions taken by Amazon that affect the publishing
	/// or status of a listing. It also includes details about any associated exemptions.
	/// </summary>
	public class IssueEnforcements : BaseClass
	{
		/// <summary>
		/// List of enforcement actions taken by Amazon that affect the publishing or status of a listing.
		/// </summary>
		[IsRequired]
		[JsonProperty("actions")]
		public List<IssueEnforcementAction> Actions { get; set; }

		/// <summary>
		/// The "exemption" field serves to convey the status of enforcement actions by Amazon.
		/// </summary>
		[IsRequired]
		[JsonProperty("exemption")]
		public IssueExemption Exemption { get; set; }
	}
}
