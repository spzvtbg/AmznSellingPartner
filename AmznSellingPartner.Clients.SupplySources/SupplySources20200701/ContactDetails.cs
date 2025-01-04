namespace AmznSellingPartner.Clients.SupplySources.SupplySources20200701
{
	using Newtonsoft.Json;

	/// <summary>
	/// The contact details
	/// </summary>
	public class ContactDetails : BaseClass
	{
		[JsonProperty("primary")]
		public Primary Primary { get; set; } 
	}
}
