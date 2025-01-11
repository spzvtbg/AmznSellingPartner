namespace AmznSellingPartner.Clients.Values
{
    public class StringValue
    {
        private string value;

        public StringValue(string value)
            => this.value = value;

        public static implicit operator StringValue(string value)
            => new StringValue(value);

        public static implicit operator string(StringValue doubleValue)
            => doubleValue.value;
    }
}
