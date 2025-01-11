namespace AmznSellingPartner.Clients.Values
{
    public class BooleanValue
    {
        private readonly bool value;

        private BooleanValue(bool value)
            => this.value = value;

        public static implicit operator BooleanValue(bool value)
            => new BooleanValue(value);

        public static implicit operator bool(BooleanValue booleanValue)
            => booleanValue.value;
    }
}
