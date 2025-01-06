namespace AmznSellingPartner.BuildTools
{
    internal class AmznHeader : AmznUnhandled
    {
        public string Type { get; set; }

        public string Description { get; set; }

        internal CsProperty OnDeserialized(string name, CsContext _)
            => new CsProperty
            {
                Name = name.ToLower(),
                Type = "string"
            }
            .HasDescription(this.Description)
            .HasJsonProperty(true);
    }
}