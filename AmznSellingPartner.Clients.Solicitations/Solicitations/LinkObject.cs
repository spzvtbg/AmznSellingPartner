namespace AmznSellingPartner.Clients.Solicitations.Solicitations
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// A Link object.
	/// </summary>
	public class LinkObject : BaseClass
	{
		/// <summary>
		/// A URI for this object.
		/// </summary>
		[JsonProperty("href")]
		[IsRequired]
		public string Href { get; set; } 

		/// <summary>
		/// An identifier for this object.
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; } 
	}
}
