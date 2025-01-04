namespace AmznSellingPartner.Clients.ProductFees.ProductFeesV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// A list of error responses returned when a request is unsuccessful.
	/// </summary>
	public class GetMyFeesEstimatesErrorList : BaseClass
	{
		[JsonProperty("errors")]
		[IsRequired]
		public List<Error> Errors { get; set; }
	}
}
