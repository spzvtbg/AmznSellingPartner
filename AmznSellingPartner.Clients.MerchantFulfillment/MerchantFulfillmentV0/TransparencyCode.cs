namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using AmznSellingPartner.Clients.Values;

	/// <summary>
	/// The transparency code associated with the item. Determine the transparency serial number with:  **1D
	/// or 2D barcode:** This has a **T** logo. Submit either the 29-character alpha-numeric identifier beginning
	/// with **AZ** or **ZA**, or the 38-character Serialized Global Trade Item Number (SGTIN). **2D barcode
	/// SN:** Submit the 7- to 20-character serial number barcode, that likely has the prefix **SN**. The serial
	/// number is applied to the same side of the packaging as the GTIN (UPC/EAN/ISBN) barcode. **QR code SN:**
	/// Submit the URL that the QR code generates.
	/// </summary>
	public class TransparencyCode : StringValue
	{
	}
}
