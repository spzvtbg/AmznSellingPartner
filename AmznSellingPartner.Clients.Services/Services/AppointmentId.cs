namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	/// <summary>
	/// The appointment identifier.
	/// </summary>
	[MinLength(5)]
	[MaxLength(100)]
	public class AppointmentId : StringValue
	{
	}
}
