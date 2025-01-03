namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// A field collected from the regulatory form.
	/// </summary>
	public class RegulatedInformationField : BaseClass
	{
		/// <summary>
		/// The unique identifier of the field.
		/// </summary>
		[IsRequired]
		[JsonProperty("FieldId")]
		public string FieldId { get; set; }

		/// <summary>
		/// The name of the field.
		/// </summary>
		[IsRequired]
		[JsonProperty("FieldLabel")]
		public string FieldLabel { get; set; }

		/// <summary>
		/// The type of field.
		/// </summary>
		[IsRequired]
		[JsonProperty("FieldType")]
		public FieldType FieldType { get; set; }

		/// <summary>
		/// The content of the field as collected in regulatory form. Note that `FileAttachment` type fields contain
		/// a URL where you can download the attachment.
		/// </summary>
		[IsRequired]
		[JsonProperty("FieldValue")]
		public string FieldValue { get; set; }
	}
}
