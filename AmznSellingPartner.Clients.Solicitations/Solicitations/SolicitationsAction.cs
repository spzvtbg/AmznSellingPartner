namespace AmznSellingPartner.Clients.Solicitations.Solicitations
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// A simple object containing the name of the template
	/// </summary>
	public class SolicitationsAction : BaseClass
	{
		[IsRequired]
		[JsonProperty("name")]
		public string Name { get; set; }
	}
}
