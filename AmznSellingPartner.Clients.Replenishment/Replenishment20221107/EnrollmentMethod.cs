namespace AmznSellingPartner.Clients.Replenishment.Replenishment20221107
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// The enrollment method used to enroll the offer into the program
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EnrollmentMethod
	{
		/// <summary>
		/// Offer was manually enrolled in the program
		/// </summary>
		[EnumMember(Value = "MANUAL")]
		MANUAL,

		/// <summary>
		/// Offer was automatically enrolled in the program
		/// </summary>
		[EnumMember(Value = "AUTOMATIC")]
		AUTOMATIC,
	}
}
