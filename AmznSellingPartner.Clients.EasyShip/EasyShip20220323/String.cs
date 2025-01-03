namespace AmznSellingPartner.Clients.EasyShip.EasyShip20220323
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	/// <summary>
	/// A string of up to 255 characters.
	/// </summary>
	[MinLength(1)]
	[MaxLength(255)]
	public class String : StringValue
	{
	}
}
