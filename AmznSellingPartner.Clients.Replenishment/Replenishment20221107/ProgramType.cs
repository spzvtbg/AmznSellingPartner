namespace AmznSellingPartner.Clients.Replenishment.Replenishment20221107
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// The replenishment program type
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ProgramType
	{
		/// <summary>
		/// Subscribe And Save Program
		/// </summary>
		[EnumMember(Value = "SUBSCRIBE_AND_SAVE")]
		SUBSCRIBE_AND_SAVE,
	}
}
