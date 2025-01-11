namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using Newtonsoft.Json;

	/// <summary>
	/// A standard image with paragraphs and a bulleted list, and extra space for technical detail
	/// s.
	/// </summary>
	public class StandardSingleImageSpecsDetailModule : BaseClass
	{
		[JsonProperty("headline")]
		public TextComponent Headline { get; set; } 

		[JsonProperty("image")]
		public ImageComponent Image { get; set; } 

		[JsonProperty("descriptionHeadline")]
		public TextComponent DescriptionHeadline { get; set; } 

		[JsonProperty("descriptionBlock1")]
		public StandardTextBlock DescriptionBlock1 { get; set; } 

		[JsonProperty("descriptionBlock2")]
		public StandardTextBlock DescriptionBlock2 { get; set; } 

		[JsonProperty("specificationHeadline")]
		public TextComponent SpecificationHeadline { get; set; } 

		[JsonProperty("specificationListBlock")]
		public StandardHeaderTextListBlock SpecificationListBlock { get; set; } 

		[JsonProperty("specificationTextBlock")]
		public StandardTextBlock SpecificationTextBlock { get; set; } 
	}
}
