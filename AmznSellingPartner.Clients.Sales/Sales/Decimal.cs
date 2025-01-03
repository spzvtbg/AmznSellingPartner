namespace AmznSellingPartner.Clients.Sales.Sales
{
	using AmznSellingPartner.Clients.Values;

	/// <summary>
	/// A decimal number with no loss of precision
	/// Useful when precision loss is unnaceptable, as with currencies
	/// Follows RFC7159 for number representation
	/// </summary>
	public class Decimal : StringValue
	{
	}
}
