namespace AmznSellingPartner.Clients.SupplySources.SupplySources20200701
{
	using Newtonsoft.Json;

	/// <summary>
	/// The address and contact details.
	/// </summary>
	public class AddressWithContact : BaseClass
	{
		[JsonProperty("contactDetails")]
		public ContactDetails ContactDetails { get; set; }

		[JsonProperty("address")]
		public Address Address { get; set; }
	}
}
