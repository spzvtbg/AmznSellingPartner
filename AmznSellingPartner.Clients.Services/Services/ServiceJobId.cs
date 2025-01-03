namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	/// <summary>
	/// Amazon identifier for the service job.
	/// </summary>
	[MinLength(1)]
	[MaxLength(100)]
	public class ServiceJobId : StringValue
	{
	}
}
