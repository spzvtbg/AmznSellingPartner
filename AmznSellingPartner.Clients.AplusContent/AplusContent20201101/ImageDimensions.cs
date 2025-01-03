namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The dimensions extending from the top left corner of the cropped image, or the top left corner of the original
	/// image if there is no cropping. Only `pixels` is allowed as the units value for ImageDimensions.
	/// </summary>
	public class ImageDimensions : BaseClass
	{
		[IsRequired]
		[JsonProperty("width")]
		public IntegerWithUnits Width { get; set; }

		[IsRequired]
		[JsonProperty("height")]
		public IntegerWithUnits Height { get; set; }
	}
}
