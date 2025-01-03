namespace AmznSellingPartner.Clients.ProductTypeDefinitions.DefinitionsProductTypes20200901
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum Verb
	{
		/// <summary>
		/// The provided resource is accessed with the HTTP GET method
		/// </summary>
		[EnumMember(Value = "GET")]
		GET,
	}
}
