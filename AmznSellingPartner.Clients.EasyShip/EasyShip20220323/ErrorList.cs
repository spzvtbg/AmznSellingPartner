namespace AmznSellingPartner.Clients.EasyShip.EasyShip20220323
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// A list of error responses returned when a request is unsuccessful.
	/// </summary>
	public class ErrorList : BaseClass
	{
		/// <summary>
		/// A list of error responses returned when a request is unsuccessful.
		/// </summary>
		[JsonProperty("errors")]
		[IsRequired]
		public List<Error> Errors { get; set; } 
	}
}
