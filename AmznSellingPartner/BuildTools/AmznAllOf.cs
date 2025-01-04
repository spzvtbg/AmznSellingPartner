namespace AmznSellingPartner.BuildTools
{
    using AmznSellingPartner;

    using System.Collections.Generic;

    internal class AmznAllOf : AmznUnhandled
    {
        public string Type { get; set; }

        public string Description { get; set; }

        public virtual string Reference { get; }

        internal virtual IEnumerable<CsProperty> GetProperties(string name, CsClass @class, CsContext context)
        {
            yield break;
        }
    }

    internal class AmznAllOfObject : AmznAllOf
    {
        public string[] Required { get; set; }

        public AmznProperties Properties { get; set; }

        internal override IEnumerable<CsProperty> GetProperties(string name, CsClass @class, CsContext context)
        {
            foreach (var proeprtyName in this.Required ?? [])
            {
                this.Properties.SetRequired(proeprtyName);
            }

            foreach (var (propertyName, propertyValue) in this.Properties ?? [])
            {
                yield return propertyValue.OnDeserialized(propertyName, @class, context);
            }
        }
    }

    internal class AmznAllOfRef : AmznAllOf
    {
        public string Ref { get; set; }

        public override string Reference
            => this.Ref.GetReferenceType();
    }
}