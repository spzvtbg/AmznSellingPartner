namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Values;

	/// <summary>
	/// A client provided unique identifier for a package being shipped. This value should be saved
	/// by the client to pass as a parameter to the getShipmentDocuments operation.
	/// </summary>
	public class PackageClientReferenceId : StringValue
	{
	}
}
