namespace AmznSellingPartner.Clients.Solicitations.Solicitations
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the getSolicitationActionsForOrder operation
	/// </summary>
	public class GetSolicitationActionsForOrderResponse : BaseClass
	{
		[JsonProperty("_links")]
		public Links Links { get; set; }

		[JsonProperty("_embedded")]
		public Embedded Embedded { get; set; }

		[JsonProperty("errors")]
		public ErrorList Errors { get; set; }
	}
}
