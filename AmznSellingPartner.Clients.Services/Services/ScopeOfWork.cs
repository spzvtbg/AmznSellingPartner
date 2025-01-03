namespace AmznSellingPartner.Clients.Services.Services
{
	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The scope of work for the order
	/// </summary>
	public class ScopeOfWork : BaseClass
	{
		/// <summary>
		/// The Amazon Standard Identification Number (ASIN) of the service job
		/// </summary>
		[JsonProperty("asin")]
		public string Asin { get; set; }

		/// <summary>
		/// The title of the service job
		/// </summary>
		[JsonProperty("title")]
		public string Title { get; set; }

		/// <summary>
		/// The number of service jobs
		/// </summary>
		[JsonProperty("quantity")]
		public int Quantity { get; set; }

		/// <summary>
		/// A list of skills required to perform the job
		/// </summary>
		[JsonProperty("requiredSkills")]
		public List<string> RequiredSkills { get; set; }
	}
}
