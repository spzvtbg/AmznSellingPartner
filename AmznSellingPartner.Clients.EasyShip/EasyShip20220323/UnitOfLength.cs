namespace AmznSellingPartner.Clients.EasyShip.EasyShip20220323
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// The unit of measurement used to measure the length
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum UnitOfLength
	{
		/// <summary>
		/// Centimeters
		/// </summary>
		[EnumMember(Value = "Cm")]
		Cm,
	}
}
