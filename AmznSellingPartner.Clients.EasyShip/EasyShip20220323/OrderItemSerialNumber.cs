namespace AmznSellingPartner.Clients.EasyShip.EasyShip20220323
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	/// <summary>
	/// A serial number for an item associated with the `OrderItemId` value
	/// </summary>
	[MaxLength(255)]
	public class OrderItemSerialNumber : StringValue
	{
	}
}
