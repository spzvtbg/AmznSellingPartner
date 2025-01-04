namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Standard product description text.
	/// </summary>
	public class StandardProductDescriptionModule : BaseClass
	{
		[JsonProperty("body")]
		[IsRequired]
		public ParagraphComponent Body { get; set; }
	}
}
