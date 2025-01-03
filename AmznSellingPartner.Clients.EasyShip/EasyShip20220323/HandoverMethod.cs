namespace AmznSellingPartner.Clients.EasyShip.EasyShip20220323
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// Identifies the method by which a seller will hand a package over to Amazon Logistics
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum HandoverMethod
	{
		/// <summary>
		/// An Amazon Logistics carrier will pickup the package(s) from the seller's pickup address
		/// </summary>
		[EnumMember(Value = "Pickup")]
		Pickup,

		/// <summary>
		/// Seller will need to drop off the package(s) to a designated location
		/// </summary>
		[EnumMember(Value = "Dropoff")]
		Dropoff,
	}
}
