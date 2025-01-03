namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// Type of Input
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum InputType
	{
		/// <summary>
		/// Input Type is Textbox
		/// </summary>
		[EnumMember(Value = "TEXTBOX")]
		TEXTBOX,

		/// <summary>
		/// Input Type is Password
		/// </summary>
		[EnumMember(Value = "PASSWORD")]
		PASSWORD,
	}
}
