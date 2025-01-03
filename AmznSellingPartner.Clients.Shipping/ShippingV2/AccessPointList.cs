namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using System.Collections.Generic;

	/// <summary>
	/// List of relevant Access points requested by shipper
	/// These access points are sorted by proximity to postal code, and are limited to 40
	/// We have internally defined a radius value to render relevant results
	/// </summary>
	public class AccessPointList : List<AccessPoint>
	{
	}
}
