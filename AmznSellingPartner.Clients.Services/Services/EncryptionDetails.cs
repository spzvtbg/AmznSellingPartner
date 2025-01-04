namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Encryption details for required client-side encryption and decryption of document contents.
	/// </summary>
	public class EncryptionDetails : BaseClass
	{
		/// <summary>
		/// The encryption standard required to encrypt or decrypt the document contents.
		/// </summary>
		[JsonProperty("standard")]
		[IsRequired]
		public Standard Standard { get; set; } 

		/// <summary>
		/// The vector to encrypt or decrypt the document contents using Cipher Block Chaining (CBC).
		/// </summary>
		[JsonProperty("initializationVector")]
		[IsRequired]
		public string InitializationVector { get; set; } 

		/// <summary>
		/// The encryption key used to encrypt or decrypt the document contents.
		/// </summary>
		[JsonProperty("key")]
		[IsRequired]
		public string Key { get; set; } 
	}
}
