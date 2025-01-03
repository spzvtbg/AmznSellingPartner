namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The instructions for optionally cropping an image. If no cropping is desired, set the dimensions to the origin
	/// l image size. If the image is cropped and no offset values are provided, then the coordinates of the top left
	/// orner of the cropped image, relative to the original image, are defaulted to (0,0).
	/// </summary>
	public class ImageCropSpecification : BaseClass
	{
		[IsRequired]
		[JsonProperty("size")]
		public ImageDimensions Size { get; set; }

		[JsonProperty("offset")]
		public ImageOffsets Offset { get; set; }
	}
}
