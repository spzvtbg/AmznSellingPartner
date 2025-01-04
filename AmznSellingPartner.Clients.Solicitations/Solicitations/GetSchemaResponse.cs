namespace AmznSellingPartner.Clients.Solicitations.Solicitations
{
	using Newtonsoft.Json;

	public class GetSchemaResponse : BaseClass
	{
		[JsonProperty("_links")]
		public Links Links { get; set; } 

		[JsonProperty("payload")]
		public Schema Payload { get; set; } 

		[JsonProperty("errors")]
		public ErrorList Errors { get; set; } 
	}
}
