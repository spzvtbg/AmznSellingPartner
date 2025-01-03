namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The document data and checksum
	/// </summary>
	public class FileContents : BaseClass
	{
		/// <summary>
		/// Data for printing labels encoded into a Base64, GZip-compressed string
		/// </summary>
		[IsRequired]
		[JsonProperty("Contents")]
		public string Contents { get; set; }

		[IsRequired]
		[JsonProperty("FileType")]
		public FileType FileType { get; set; }

		/// <summary>
		/// An MD5 hash to validate the PDF document data, in the form of a Base64 string
		/// </summary>
		[IsRequired]
		[JsonProperty("Checksum")]
		public string Checksum { get; set; }
	}
}
