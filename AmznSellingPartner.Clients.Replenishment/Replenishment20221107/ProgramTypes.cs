namespace AmznSellingPartner.Clients.Replenishment.Replenishment20221107
{
	using AmznSellingPartner.Clients.Attributes;

	using System.Collections.Generic;

	/// <summary>
	/// A list of replenishment program types
	/// </summary>
	[MinItems(1)]
	[UniqueItems]
	public class ProgramTypes : List<ProgramType>
	{
	}
}
