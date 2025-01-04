namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The standard company logo image.
	/// </summary>
	public class StandardCompanyLogoModule : BaseClass
	{
		[JsonProperty("companyLogo")]
		[IsRequired]
		public ImageComponent CompanyLogo { get; set; } 
	}
}
