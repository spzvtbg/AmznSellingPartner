namespace AmznSellingPartner.BuildTools
{
    using AmznSellingPartner;

    internal class AmznDefinitionItem : AmznUnhandled
    {
        public string Type { get; set; }

        public string Description { get; set; }

        internal virtual CsProperty OnDeserialized(string name, CsContext context)
              => new CsProperty { Name = name }
                    .HasDescription(this.Description);
    }

    internal class AmznDefinitionItemString : AmznDefinitionItem
    {
        public int? MaxLength { get; set; }

        internal override CsProperty OnDeserialized(string name, CsContext context)
        {
            var property = base.OnDeserialized(name, context)
                               .HasType("string");

            if (this.MaxLength is not null)
            {
                property.HasAttribute(nameof(this.MaxLength), this.MaxLength);
            }

            return property;
        }
    }

    internal class AmznDefinitionItemObject : AmznDefinitionItem
    {
        internal override CsProperty OnDeserialized(string name, CsContext context)
            => base.OnDeserialized(name, context)
                   .HasType("object");
    }

    internal class AmznDefinitionItemProeprties : AmznDefinitionItem
    {
        public AmznProperties Properties { get; set; }

        internal override CsProperty OnDeserialized(string name, CsContext context)
              => base.OnDeserialized(name, context)
                     .HasType(new AmznDefinitionObject { Properties = this.Properties }
                     .OnDeserialized(name, context)
                     .GetTypeName());
    }

    internal class AmznDefinitionItemRef : AmznDefinitionItem
    {
        public string Ref { get; set; }

        internal override CsProperty OnDeserialized(string name, CsContext context)
            => base.OnDeserialized(name, context)
                   .HasType(this.Ref.GetReferenceType());
    }
}