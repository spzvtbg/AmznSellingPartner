namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The top left corner of the cropped image, specified in the original image's coordinate space
	/// </summary>
	public class ImageOffsets : BaseClass
	{
		[IsRequired]
		[JsonProperty("x")]
		public IntegerWithUnits X { get; set; }

		[IsRequired]
		[JsonProperty("y")]
		public IntegerWithUnits Y { get; set; }
	}
}
