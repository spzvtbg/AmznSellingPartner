namespace AmznSellingPartner.Clients.SupplySources.SupplySources20200701
{
	using Newtonsoft.Json;

	public class Primary : BaseClass
	{
		[JsonProperty("email")]
		public EmailAddress Email { get; set; } 

		/// <summary>
		/// The phone number of the person, business or institution.
		/// </summary>
		[JsonProperty("phone")]
		public string Phone { get; set; } 
	}
}
