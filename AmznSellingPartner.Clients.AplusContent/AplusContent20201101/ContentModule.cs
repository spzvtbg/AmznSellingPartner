namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// An A+ Content module. An A+ Content document is composed of content modules. The contentModuleType property
	/// selects which content module types to use.
	/// </summary>
	public class ContentModule : BaseClass
	{
		[IsRequired]
		[JsonProperty("contentModuleType")]
		public ContentModuleType ContentModuleType { get; set; }

		[JsonProperty("standardCompanyLogo")]
		public StandardCompanyLogoModule StandardCompanyLogo { get; set; }

		[JsonProperty("standardComparisonTable")]
		public StandardComparisonTableModule StandardComparisonTable { get; set; }

		[JsonProperty("standardFourImageText")]
		public StandardFourImageTextModule StandardFourImageText { get; set; }

		[JsonProperty("standardFourImageTextQuadrant")]
		public StandardFourImageTextQuadrantModule StandardFourImageTextQuadrant { get; set; }

		[JsonProperty("standardHeaderImageText")]
		public StandardHeaderImageTextModule StandardHeaderImageText { get; set; }

		[JsonProperty("standardImageSidebar")]
		public StandardImageSidebarModule StandardImageSidebar { get; set; }

		[JsonProperty("standardImageTextOverlay")]
		public StandardImageTextOverlayModule StandardImageTextOverlay { get; set; }

		[JsonProperty("standardMultipleImageText")]
		public StandardMultipleImageTextModule StandardMultipleImageText { get; set; }

		[JsonProperty("standardProductDescription")]
		public StandardProductDescriptionModule StandardProductDescription { get; set; }

		[JsonProperty("standardSingleImageHighlights")]
		public StandardSingleImageHighlightsModule StandardSingleImageHighlights { get; set; }

		[JsonProperty("standardSingleImageSpecsDetail")]
		public StandardSingleImageSpecsDetailModule StandardSingleImageSpecsDetail { get; set; }

		[JsonProperty("standardSingleSideImage")]
		public StandardSingleSideImageModule StandardSingleSideImage { get; set; }

		[JsonProperty("standardTechSpecs")]
		public StandardTechSpecsModule StandardTechSpecs { get; set; }

		[JsonProperty("standardText")]
		public StandardTextModule StandardText { get; set; }

		[JsonProperty("standardThreeImageText")]
		public StandardThreeImageTextModule StandardThreeImageText { get; set; }
	}
}
