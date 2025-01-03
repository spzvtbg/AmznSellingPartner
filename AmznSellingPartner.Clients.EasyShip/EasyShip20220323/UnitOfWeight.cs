namespace AmznSellingPartner.Clients.EasyShip.EasyShip20220323
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// The unit of measurement used to measure the weight
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum UnitOfWeight
	{
		/// <summary>
		/// Grams
		/// </summary>
		[EnumMember(Value = "Grams")]
		Grams,

		/// <summary>
		/// Grams
		/// </summary>
		[EnumMember(Value = "G")]
		G,
	}
}
