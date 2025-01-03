namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// A technician who is assigned to perform the service job in part or in full.
	/// </summary>
	public class Technician : BaseClass
	{
		/// <summary>
		/// The technician identifier.
		/// </summary>
		[MinLength(1)]
		[MaxLength(50)]
		[JsonProperty("technicianId")]
		public string TechnicianId { get; set; }

		/// <summary>
		/// The name of the technician.
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }
	}
}
