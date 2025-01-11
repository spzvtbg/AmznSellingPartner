namespace AmznSellingPartner.Clients.Replenishment.Replenishment20221107
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// The current eligibility status of an offer.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EligibilityStatus
	{
		/// <summary>
		/// The offer is able to fulfill current subscriptions and add new subscriptions.
		/// </summary>
		[EnumMember(Value = "ELIGIBLE")]
		ELIGIBLE,

		/// <summary>
		/// The offer will not be able to add new subscriptions and existing subscriptions will be can
		/// celled.
		/// </summary>
		[EnumMember(Value = "INELIGIBLE")]
		INELIGIBLE,

		/// <summary>
		/// The offer will not be able to add new subscriptions but existing subscriptions will be ful
		/// filled.
		/// </summary>
		[EnumMember(Value = "SUSPENDED")]
		SUSPENDED,

		/// <summary>
		/// The offer will not be able to add new subscriptions but existing subscriptions will be fulfilled.
		/// This eligibility status also blocks one-time purchases to preserve inventory for existing
		/// subscriptions.
		/// </summary>
		[EnumMember(Value = "REPLENISHMENT_ONLY_ORDERING")]
		REPLENISHMENT_ONLY_ORDERING,
	}
}
