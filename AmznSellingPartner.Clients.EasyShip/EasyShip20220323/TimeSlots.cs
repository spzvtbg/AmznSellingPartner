namespace AmznSellingPartner.Clients.EasyShip.EasyShip20220323
{
	using AmznSellingPartner.Clients.Attributes;

	using System.Collections.Generic;

	/// <summary>
	/// A list of time slots
	/// </summary>
	[MinItems(1)]
	[MaxItems(500)]
	public class TimeSlots : List<TimeSlot>
	{
	}
}
