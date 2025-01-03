namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// A reference to an image, hosted in the A+ Content media library
	/// </summary>
	public class ImageComponent : BaseClass
	{
		/// <summary>
		/// This identifier is provided by the Selling Partner API for Uploads
		/// </summary>
		[IsRequired]
		[MinLength(1)]
		[JsonProperty("uploadDestinationId")]
		public string UploadDestinationId { get; set; }

		[IsRequired]
		[JsonProperty("imageCropSpecification")]
		public ImageCropSpecification ImageCropSpecification { get; set; }

		/// <summary>
		/// The alternative text for the image
		/// </summary>
		[IsRequired]
		[MinLength(1)]
		[MaxLength(100)]
		[JsonProperty("altText")]
		public string AltText { get; set; }
	}
}
