namespace AmznSellingPartner.Clients.EasyShip.EasyShip20220323
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// The file format in which the shipping label will be created.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum LabelFormat
	{
		[EnumMember(Value = "PDF")]
		PDF,

		[EnumMember(Value = "ZPL")]
		ZPL,
	}
}
