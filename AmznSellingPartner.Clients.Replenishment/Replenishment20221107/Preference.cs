namespace AmznSellingPartner.Clients.Replenishment.Replenishment20221107
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Offer preferences that you can include in the result filter criteria
	/// </summary>
	public class Preference : BaseClass
	{
		/// <summary>
		/// Filters the results to only include offers with the auto-enrollment preference specified
		/// </summary>
		[MinItems(1)]
		[UniqueItems]
		[JsonProperty("autoEnrollment")]
		public List<AutoEnrollmentPreference> AutoEnrollment { get; set; }
	}
}
