namespace AmznSellingPartner.Clients.ListingsItems.ListingsItems20210801
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;

	/// <summary>
	/// Conveying the status of the listed enforcement actions and, if applicable, provides information about the exem
	/// tion's expiry date.
	/// </summary>
	public class IssueExemption : BaseClass
	{
		/// <summary>
		/// This field indicates the current exemption status for the listed enforcement actions. It can take values such
		/// s `EXEMPT`, signifying permanent exemption, `EXEMPT_UNTIL_EXPIRY_DATE` indicating temporary exemption until a
		/// pecified date, or `NOT_EXEMPT` signifying no exemptions, and enforcement actions were already applied.
		/// </summary>
		[IsRequired]
		[JsonProperty("status")]
		public Status Status { get; set; }

		/// <summary>
		/// This field represents the timestamp, following the ISO 8601 format, which specifies the date when temporary ex
		/// mptions, if applicable, will expire, and Amazon will begin enforcing the listed actions.
		/// </summary>
		[JsonProperty("expiryDate")]
		public DateTime ExpiryDate { get; set; }
	}
}
