namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// Label page type
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PageType
	{
		/// <summary>
		/// For the use of a thermal printer
		/// Supports non-Amazon-partnered shipments
		/// </summary>
		[EnumMember(Value = "THERMAL_NONPCP")]
		THERMAL_NONPCP,

		/// <summary>
		/// One label per sheet of US Letter paper
		/// Only for non-Amazon-partnered shipments
		/// </summary>
		[EnumMember(Value = "PLAIN_PAPER")]
		PLAIN_PAPER,

		/// <summary>
		/// Six labels per US Letter label sheet
		/// </summary>
		[EnumMember(Value = "LETTER_6")]
		LETTER_6,
	}
}
