namespace AmznSellingPartner.Clients.Solicitations.Solicitations
{
	using Newtonsoft.Json;

	/// <summary>
	/// A JSON schema document describing the expected payload of the action. This object can be validated against
	/// <a href=http://json-schema.org/draft-04/schema>http://json-schema.org/draft-04/schema</a>.
	/// </summary>
	public class Schema : BaseClass
	{
		[JsonProperty("AdditionalValue")]
		public object AdditionalValue { get; set; }
	}
}
