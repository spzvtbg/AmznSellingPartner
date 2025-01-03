namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using AmznSellingPartner.Clients.Attributes;

	using System.Collections.Generic;

	/// <summary>
	/// A set of messages to the user, such as warnings or comments.
	/// </summary>
	[UniqueItems]
	public class MessageSet : List<Error>
	{
	}
}
