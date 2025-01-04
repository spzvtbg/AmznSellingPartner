namespace AmznSellingPartner.Clients.Messaging.Messaging
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	public class Links : BaseClass
	{
		[JsonProperty("self")]
		[IsRequired]
		public LinkObject Self { get; set; } 

		/// <summary>
		/// Eligible actions for the specified amazonOrderId.
		/// </summary>
		[JsonProperty("actions")]
		[IsRequired]
		public List<LinkObject> Actions { get; set; } 

		[JsonProperty("schema")]
		[IsRequired]
		public LinkObject Schema { get; set; } 
	}
}
