namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The format options available for a label.
	/// </summary>
	public class PrintOption : BaseClass
	{
		/// <summary>
		/// A list of the supported DPI options for a document.
		/// </summary>
		[JsonProperty("supportedDPIs")]
		public List<Dpi> SupportedDPIs { get; set; }

		/// <summary>
		/// A list of the supported page layout options for a document.
		/// </summary>
		[IsRequired]
		[JsonProperty("supportedPageLayouts")]
		public List<PageLayout> SupportedPageLayouts { get; set; }

		/// <summary>
		/// A list of the supported needFileJoining boolean values for a document.
		/// </summary>
		[IsRequired]
		[JsonProperty("supportedFileJoiningOptions")]
		public List<NeedFileJoining> SupportedFileJoiningOptions { get; set; }

		/// <summary>
		/// A list of the supported documented details.
		/// </summary>
		[IsRequired]
		[JsonProperty("supportedDocumentDetails")]
		public List<SupportedDocumentDetail> SupportedDocumentDetails { get; set; }
	}
}
