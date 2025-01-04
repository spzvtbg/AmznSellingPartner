namespace AmznSellingPartner
{
    internal class AmznHeader : AmznUnhandled
    {
        public string Type { get; set; }

        public string Description { get; set; }

        internal CsProperty OnDeserialized(string name, CsContext context) 
            => new CsProperty
            {
                Name = name,
                Type = "string"
            }
            .HasDescription(this.Description)
            .HasAttribute("FromHeader", $"\"{name}\"");
    }
}