namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using System.Collections.Generic;

	/// <summary>
	/// A list of email addresses that the seller provides that are used by Amazon to send ship-complete notifications
	/// to recipients on behalf of the seller.
	/// </summary>
	[MaxLength(64)]
	public class NotificationEmailList : List<string>
	{
	}
}
