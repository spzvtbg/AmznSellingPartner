namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using System;

	[HttpGet("/fba/outbound/2020-07-01/features/inventory/{featureName}")]
	public class GetFeatureInventoryGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// The marketplace for which to return a list of the inventory that is eligible for the specified featu
		/// re.
		/// </summary>
		[InQuery("marketplaceId")]
		[IsRequired]
		public string MarketplaceId { get; set; }

		/// <summary>
		/// The name of the feature for which to return a list of eligible inventory.
		/// </summary>
		[InPath("featureName")]
		[IsRequired]
		public string FeatureName { get; set; }

		/// <summary>
		/// A string token returned in the response to your previous request that is used to return the next response
		/// page. A value of null will return the first page.
		/// </summary>
		[InQuery("nextToken")]
		public string NextToken { get; set; }

		/// <summary>
		/// A date that you can use to select inventory that has been updated since a specified date. An update is
		/// defined as any change in feature-enabled inventory availability. The date must be in the format yyyy
		/// -MM-ddTHH:mm:ss.sssZ
		/// </summary>
		[InQuery("queryStartDate")]
		public DateTime QueryStartDate { get; set; }
	}
}
