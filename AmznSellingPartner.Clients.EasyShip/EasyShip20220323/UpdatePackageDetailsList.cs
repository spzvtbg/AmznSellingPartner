namespace AmznSellingPartner.Clients.EasyShip.EasyShip20220323
{
	using AmznSellingPartner.Clients.Attributes;

	using System.Collections.Generic;

	/// <summary>
	/// A list of package update details.
	/// </summary>
	[MinItems(1)]
	[MaxItems(500)]
	public class UpdatePackageDetailsList : List<UpdatePackageDetails>
	{
	}
}
