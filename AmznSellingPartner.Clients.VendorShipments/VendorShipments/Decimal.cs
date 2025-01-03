namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
	using AmznSellingPartner.Clients.Values;

	/// <summary>
	/// A decimal number with no loss of precision
	/// Useful when precision loss is unacceptable, as with currencies
	/// Follows RFC7159 for number representation
	/// <br>**Pattern** : `^-?(0|([1-9]\d*))(\
	/// \d+)?([eE][+-]?\d+)?`
	/// </summary>
	public class Decimal : StringValue
	{
	}
}
