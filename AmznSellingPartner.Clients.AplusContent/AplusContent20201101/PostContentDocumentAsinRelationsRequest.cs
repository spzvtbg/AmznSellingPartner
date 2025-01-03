namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	public class PostContentDocumentAsinRelationsRequest : BaseClass
	{
		[IsRequired]
		[JsonProperty("asinSet")]
		public AsinSet AsinSet { get; set; }
	}
}
