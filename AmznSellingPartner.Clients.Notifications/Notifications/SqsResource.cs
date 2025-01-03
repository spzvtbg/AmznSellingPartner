namespace AmznSellingPartner.Clients.Notifications.Notifications
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The information required to create an Amazon Simple Queue Service (Amazon SQS) queue destination
	/// </summary>
	public class SqsResource : BaseClass
	{
		/// <summary>
		/// The Amazon Resource Name (ARN) associated with the SQS queue
		/// </summary>
		[IsRequired]
		[Pattern("^arn:aws:sqs:\\S+:\\S+:\\S+")]
		[MaxLength(1000)]
		[JsonProperty("arn")]
		public string Arn { get; set; }
	}
}
