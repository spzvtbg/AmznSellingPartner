namespace AmznSellingPartner.Clients.EasyShip.EasyShip20220323
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	/// <summary>
	/// The numerical value of the specified dimension.
	/// </summary>
	[Minimum(0.01)]
	public class Dimension : IntValue
	{
	}
}
