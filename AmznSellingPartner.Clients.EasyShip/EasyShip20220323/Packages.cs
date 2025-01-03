namespace AmznSellingPartner.Clients.EasyShip.EasyShip20220323
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// A list of packages.
	/// </summary>
	public class Packages : BaseClass
	{
		/// <summary>
		/// A list of packages.
		/// </summary>
		[IsRequired]
		[MinItems(1)]
		[MaxItems(500)]
		[JsonProperty("packagesValue")]
		public List<Package> PackagesValue { get; set; }
	}
}
