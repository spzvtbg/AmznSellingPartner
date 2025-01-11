namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using Newtonsoft.Json;

	/// <summary>
	/// Two images, two paragraphs, and two bulleted lists. One image is smaller and displayed in the
	/// sidebar.
	/// </summary>
	public class StandardImageSidebarModule : BaseClass
	{
		[JsonProperty("headline")]
		public TextComponent Headline { get; set; } 

		[JsonProperty("imageCaptionBlock")]
		public StandardImageCaptionBlock ImageCaptionBlock { get; set; } 

		[JsonProperty("descriptionTextBlock")]
		public StandardTextBlock DescriptionTextBlock { get; set; } 

		[JsonProperty("descriptionListBlock")]
		public StandardTextListBlock DescriptionListBlock { get; set; } 

		[JsonProperty("sidebarImageTextBlock")]
		public StandardImageTextBlock SidebarImageTextBlock { get; set; } 

		[JsonProperty("sidebarListBlock")]
		public StandardTextListBlock SidebarListBlock { get; set; } 
	}
}
