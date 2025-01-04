namespace AmznSellingPartner.Clients.ProductTypeDefinitions.DefinitionsProductTypes20200901
{
	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// A property group represents a logical grouping of schema properties that can be used for display or informational
	/// purposes.
	/// </summary>
	public class PropertyGroup : BaseClass
	{
		/// <summary>
		/// The display label of the property group.
		/// </summary>
		[JsonProperty("title")]
		public string Title { get; set; } 

		/// <summary>
		/// The description of the property group.
		/// </summary>
		[JsonProperty("description")]
		public string Description { get; set; } 

		/// <summary>
		/// The names of the schema properties for the property group.
		/// </summary>
		[JsonProperty("propertyNames")]
		public List<string> PropertyNames { get; set; } 
	}
}
