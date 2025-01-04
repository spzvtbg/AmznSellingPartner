namespace AmznSellingPartner.Clients.Replenishment.Replenishment20221107
{
	using Newtonsoft.Json;

	/// <summary>
	/// An object which contains the preferences applied to the offer.
	/// </summary>
	public class OfferProgramConfigurationPreferences : BaseClass
	{
		/// <summary>
		/// The auto-enrollment preference indicates whether the offer is opted-in to or opted-out of Amazon's auto-enrollment
		/// feature.
		/// </summary>
		[JsonProperty("autoEnrollment")]
		public AutoEnrollmentPreference AutoEnrollment { get; set; } 
	}
}
