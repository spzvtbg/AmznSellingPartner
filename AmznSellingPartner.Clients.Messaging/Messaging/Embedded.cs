namespace AmznSellingPartner.Clients.Messaging.Messaging
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	public class Embedded : BaseClass
	{
		[IsRequired]
		[JsonProperty("actions")]
		public List<GetMessagingActionResponse> Actions { get; set; }

		[JsonProperty("schema")]
		public GetSchemaResponse Schema { get; set; }
	}
}
