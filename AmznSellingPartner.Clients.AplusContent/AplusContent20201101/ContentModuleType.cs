namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    /// <summary>
    /// The type of A+ Content module.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ContentModuleType
    {
        /// <summary>
        /// The standard company logo image.
        /// </summary>
        [EnumMember(Value = "STANDARD_COMPANY_LOGO")]
        STANDARD_COMPANY_LOGO,

        /// <summary>
        /// The standard product comparison table or chart.
        /// </summary>
        [EnumMember(Value = "STANDARD_COMPARISON_TABLE")]
        STANDARD_COMPARISON_TABLE,

        /// <summary>
        /// Four standard images with text, presented across a single row.
        /// </summary>
        [EnumMember(Value = "STANDARD_FOUR_IMAGE_TEXT")]
        STANDARD_FOUR_IMAGE_TEXT,

        /// <summary>
        /// Four standard images with text, presented on a grid of four quadrants.
        /// </summary>
        [EnumMember(Value = "STANDARD_FOUR_IMAGE_TEXT_QUADRANT")]
        STANDARD_FOUR_IMAGE_TEXT_QUADRANT,

        /// <summary>
        /// Standard headline text, an image, and body text.
        /// </summary>
        [EnumMember(Value = "STANDARD_HEADER_IMAGE_TEXT")]
        STANDARD_HEADER_IMAGE_TEXT,

        /// <summary>
        /// Two images, two paragraphs, and two bulleted lists. One image is smaller and is displayed in
        /// the sidebar.
        /// </summary>
        [EnumMember(Value = "STANDARD_IMAGE_SIDEBAR")]
        STANDARD_IMAGE_SIDEBAR,

        /// <summary>
        /// A standard background image with a floating text box.
        /// </summary>
        [EnumMember(Value = "STANDARD_IMAGE_TEXT_OVERLAY")]
        STANDARD_IMAGE_TEXT_OVERLAY,

        /// <summary>
        /// Standard images with text, presented one at a time. The user clicks on thumbnails to view each
        /// block.
        /// </summary>
        [EnumMember(Value = "STANDARD_MULTIPLE_IMAGE_TEXT")]
        STANDARD_MULTIPLE_IMAGE_TEXT,

        /// <summary>
        /// Standard product description text.
        /// </summary>
        [EnumMember(Value = "STANDARD_PRODUCT_DESCRIPTION")]
        STANDARD_PRODUCT_DESCRIPTION,

        /// <summary>
        /// A standard image with several paragraphs and a bulleted list.
        /// </summary>
        [EnumMember(Value = "STANDARD_SINGLE_IMAGE_HIGHLIGHTS")]
        STANDARD_SINGLE_IMAGE_HIGHLIGHTS,

        /// <summary>
        /// A standard image with paragraphs and a bulleted list, and extra space for technical detail
        /// s.
        /// </summary>
        [EnumMember(Value = "STANDARD_SINGLE_IMAGE_SPECS_DETAIL")]
        STANDARD_SINGLE_IMAGE_SPECS_DETAIL,

        /// <summary>
        /// A standard headline and body text with an image on the side.
        /// </summary>
        [EnumMember(Value = "STANDARD_SINGLE_SIDE_IMAGE")]
        STANDARD_SINGLE_SIDE_IMAGE,

        /// <summary>
        /// The standard table of technical feature names and definitions.
        /// </summary>
        [EnumMember(Value = "STANDARD_TECH_SPECS")]
        STANDARD_TECH_SPECS,

        /// <summary>
        /// Standard headline and body text.
        /// </summary>
        [EnumMember(Value = "STANDARD_TEXT")]
        STANDARD_TEXT,

        /// <summary>
        /// Three standard images with text, presented across one row.
        /// </summary>
        [EnumMember(Value = "STANDARD_THREE_IMAGE_TEXT")]
        STANDARD_THREE_IMAGE_TEXT,
    }
}
