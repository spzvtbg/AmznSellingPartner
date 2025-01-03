namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using AmznSellingPartner.Clients.Attributes;

	using System.Collections.Generic;

	/// <summary>
	/// A list of A+ Content modules
	/// </summary>
	[MinItems(1)]
	[MaxItems(100)]
	public class ContentModuleList : List<ContentModule>
	{
	}
}
