namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The seller's contact information
	/// </summary>
	public class ContactInformation : BaseClass
	{
		/// <summary>
		/// The email address
		/// </summary>
		[MinLength(1)]
		[MaxLength(1024)]
		[JsonProperty("email")]
		public string Email { get; set; }

		/// <summary>
		/// The contact's name
		/// </summary>
		[IsRequired]
		[MinLength(1)]
		[MaxLength(50)]
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// The phone number
		/// </summary>
		[IsRequired]
		[MinLength(1)]
		[MaxLength(20)]
		[JsonProperty("phoneNumber")]
		public string PhoneNumber { get; set; }
	}
}
