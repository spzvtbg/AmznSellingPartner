namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The document data and checksum.
	/// </summary>
	public class FileContents : BaseClass
	{
		/// <summary>
		/// Data for printing labels encoded into a Base64, GZip-compressed string.
		/// </summary>
		[JsonProperty("Contents")]
		[IsRequired]
		public string Contents { get; set; } 

		[JsonProperty("FileType")]
		[IsRequired]
		public FileType FileType { get; set; } 

		/// <summary>
		/// An MD5 hash to validate the PDF document data, in the form of a Base64 string.
		/// </summary>
		[JsonProperty("Checksum")]
		[IsRequired]
		public string Checksum { get; set; } 
	}
}
