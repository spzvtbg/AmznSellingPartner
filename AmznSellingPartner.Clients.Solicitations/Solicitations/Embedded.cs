namespace AmznSellingPartner.Clients.Solicitations.Solicitations
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	public class Embedded : BaseClass
	{
		[IsRequired]
		[JsonProperty("actions")]
		public List<GetSolicitationActionResponse> Actions { get; set; }

		[JsonProperty("schema")]
		public GetSchemaResponse Schema { get; set; }
	}
}
