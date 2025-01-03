namespace AmznSellingPartner.Clients.EasyShip.EasyShip20220323
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The request body for the POST /easyShip/2022-03-23/packages/bulk API
	/// </summary>
	public class CreateScheduledPackagesRequest : BaseClass
	{
		[IsRequired]
		[JsonProperty("marketplaceId")]
		public String MarketplaceId { get; set; }

		/// <summary>
		/// An array allowing users to specify orders to be scheduled
		/// </summary>
		[IsRequired]
		[MinItems(1)]
		[JsonProperty("orderScheduleDetailsList")]
		public List<OrderScheduleDetails> OrderScheduleDetailsList { get; set; }

		[IsRequired]
		[JsonProperty("labelFormat")]
		public LabelFormat LabelFormat { get; set; }
	}
}
