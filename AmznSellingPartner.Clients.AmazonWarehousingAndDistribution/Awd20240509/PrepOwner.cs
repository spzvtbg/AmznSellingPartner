namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// The owner of the preparations, if special preparations are required
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PrepOwner
	{
		/// <summary>
		/// Amazon owns the preparation
		/// </summary>
		[EnumMember(Value = "AMAZON")]
		AMAZON,

		/// <summary>
		/// The seller owns the preparation
		/// </summary>
		[EnumMember(Value = "SELF")]
		SELF,
	}
}
