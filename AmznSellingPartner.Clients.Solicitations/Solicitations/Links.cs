namespace AmznSellingPartner.Clients.Solicitations.Solicitations
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	public class Links : BaseClass
	{
		[IsRequired]
		[JsonProperty("self")]
		public LinkObject Self { get; set; }

		/// <summary>
		/// Eligible actions for the specified amazonOrderId.
		/// </summary>
		[IsRequired]
		[JsonProperty("actions")]
		public List<LinkObject> Actions { get; set; }

		[IsRequired]
		[JsonProperty("schema")]
		public LinkObject Schema { get; set; }
	}
}
