namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The dimensions extending from the top left corner of the cropped image, or the top left corner of the
	/// original image if there is no cropping. Only `pixels` is allowed as the units value for ImageDimensi
	/// ons.
	/// </summary>
	public class ImageDimensions : BaseClass
	{
		[JsonProperty("width")]
		[IsRequired]
		public IntegerWithUnits Width { get; set; }

		[JsonProperty("height")]
		[IsRequired]
		public IntegerWithUnits Height { get; set; }
	}
}
