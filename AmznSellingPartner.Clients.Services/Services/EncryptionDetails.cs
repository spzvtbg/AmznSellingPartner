namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Encryption details for required client-side encryption and decryption of document contents
	/// </summary>
	public class EncryptionDetails : BaseClass
	{
		/// <summary>
		/// The encryption standard required to encrypt or decrypt the document contents
		/// </summary>
		[IsRequired]
		[JsonProperty("standard")]
		public Standard Standard { get; set; }

		/// <summary>
		/// The vector to encrypt or decrypt the document contents using Cipher Block Chaining (CBC)
		/// </summary>
		[IsRequired]
		[JsonProperty("initializationVector")]
		public string InitializationVector { get; set; }

		/// <summary>
		/// The encryption key used to encrypt or decrypt the document contents
		/// </summary>
		[IsRequired]
		[JsonProperty("key")]
		public string Key { get; set; }
	}
}
