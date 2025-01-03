namespace AmznSellingPartner.Clients.Replenishment.Replenishment20221107
{
	using Newtonsoft.Json;

	/// <summary>
	/// The offer program configuration contains a set of program properties for an offer
	/// </summary>
	public class OfferProgramConfiguration : BaseClass
	{
		/// <summary>
		/// An object which contains the preferences applied to the offer
		/// </summary>
		[JsonProperty("preferences")]
		public OfferProgramConfigurationPreferences Preferences { get; set; }

		/// <summary>
		/// An object which contains the promotions applied to the offer
		/// </summary>
		[JsonProperty("promotions")]
		public OfferProgramConfigurationPromotions Promotions { get; set; }

		/// <summary>
		/// Determines whether the offer was automatically or manually enrolled in the program
		/// This property is only supported for sellers and not vendors
		/// </summary>
		[JsonProperty("enrollmentMethod")]
		public EnrollmentMethod EnrollmentMethod { get; set; }
	}
}
