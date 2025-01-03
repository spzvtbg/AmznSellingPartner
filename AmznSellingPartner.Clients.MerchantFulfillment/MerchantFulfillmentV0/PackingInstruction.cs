namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum PackingInstruction
	{
		/// <summary>
		/// Ion PI965 Section IA (LiBa)
		/// </summary>
		[EnumMember(Value = "PI965_SECTION_IA")]
		PI965_SECTION_IA,

		/// <summary>
		/// Ion PI965 Section IB (LiBa)
		/// </summary>
		[EnumMember(Value = "PI965_SECTION_IB")]
		PI965_SECTION_IB,

		/// <summary>
		/// Ion PI965 Section II (LiBa)
		/// </summary>
		[EnumMember(Value = "PI965_SECTION_II")]
		PI965_SECTION_II,

		/// <summary>
		/// Ion PI966 Section I (LiBa with equipment)
		/// </summary>
		[EnumMember(Value = "PI966_SECTION_I")]
		PI966_SECTION_I,

		/// <summary>
		/// Ion PI966 Section II (LiBa with equipment)
		/// </summary>
		[EnumMember(Value = "PI966_SECTION_II")]
		PI966_SECTION_II,

		/// <summary>
		/// Ion PI967 Section I (LiBa in equipment)
		/// </summary>
		[EnumMember(Value = "PI967_SECTION_I")]
		PI967_SECTION_I,

		/// <summary>
		/// Ion PI967 Section II (LiBa in equipment)
		/// </summary>
		[EnumMember(Value = "PI967_SECTION_II")]
		PI967_SECTION_II,

		/// <summary>
		/// Metal PI968 Section IA (LiBa)
		/// </summary>
		[EnumMember(Value = "PI968_SECTION_IA")]
		PI968_SECTION_IA,

		/// <summary>
		/// Metal PI968 Section IB (LiBa)
		/// </summary>
		[EnumMember(Value = "PI968_SECTION_IB")]
		PI968_SECTION_IB,

		/// <summary>
		/// Metal PI969 Section I (LiBa with equipment)
		/// </summary>
		[EnumMember(Value = "PI969_SECTION_I")]
		PI969_SECTION_I,

		/// <summary>
		/// Metal PI969 Section II (LiBa with equipment)
		/// </summary>
		[EnumMember(Value = "PI969_SECTION_II")]
		PI969_SECTION_II,

		/// <summary>
		/// Metal PI970 Section I (LiBa in equipment)
		/// </summary>
		[EnumMember(Value = "PI970_SECTION_I")]
		PI970_SECTION_I,

		/// <summary>
		/// Metal PI970 Section II (LiBa in equipment)
		/// </summary>
		[EnumMember(Value = "PI970_SECTION_II")]
		PI970_SECTION_II,
	}
}
