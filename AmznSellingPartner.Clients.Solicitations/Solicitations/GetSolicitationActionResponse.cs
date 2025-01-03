namespace AmznSellingPartner.Clients.Solicitations.Solicitations
{
	using Newtonsoft.Json;

	/// <summary>
	/// Describes a solicitation action that can be taken for an order. Provides a JSON Hypertext Application Language
	/// (HAL) link to the JSON schema document that describes the expected input.
	/// </summary>
	public class GetSolicitationActionResponse : BaseClass
	{
		[JsonProperty("_links")]
		public Links Links { get; set; }

		[JsonProperty("_embedded")]
		public Embedded Embedded { get; set; }

		[JsonProperty("payload")]
		public SolicitationsAction Payload { get; set; }

		[JsonProperty("errors")]
		public ErrorList Errors { get; set; }
	}
}
