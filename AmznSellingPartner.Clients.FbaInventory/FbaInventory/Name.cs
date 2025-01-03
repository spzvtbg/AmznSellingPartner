namespace AmznSellingPartner.Clients.FbaInventory.FbaInventory
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum Name
	{
		/// <summary>
		/// Short Term for 1-10 days
		/// </summary>
		[EnumMember(Value = "researchingQuantityInShortTerm")]
		researchingQuantityInShortTerm,

		/// <summary>
		/// Mid Term for 11-20 days
		/// </summary>
		[EnumMember(Value = "researchingQuantityInMidTerm")]
		researchingQuantityInMidTerm,

		/// <summary>
		/// Long Term for 21 days or longer
		/// </summary>
		[EnumMember(Value = "researchingQuantityInLongTerm")]
		researchingQuantityInLongTerm,
	}
}
