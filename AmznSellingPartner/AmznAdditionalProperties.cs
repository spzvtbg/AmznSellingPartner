namespace AmznSellingPartner
{
    internal class AmznAdditionalProperties(bool? boolean) : AmznUnhandled
    {
        public string Type { get; set; }

        public string Ref { get; set; }

        public bool? Boolean { get; set; } = boolean;

        public CsProperty Property
        {
            get
            {
                var type = "object";

                if (this.Boolean.HasValue)
                {
                    type = "bool?";
                }
                else if (this.Ref is not null)
                {
                    type = this.Ref.GetReferenceType();
                }
                else if (this.Type is not null)
                {
                    type = this.Type;
                }

                return new CsProperty() { Type = type }.HasJsonProperty(true);
            }
        }


        public static implicit operator AmznAdditionalProperties(bool? boolean)
            => new AmznAdditionalProperties(boolean);
    }
}
