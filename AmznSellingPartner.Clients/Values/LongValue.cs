namespace AmznSellingPartner.Clients.Values
{
    public class LongValue
    {
        private long value;

        public LongValue()
        {

        }

        public LongValue(long value)
            => this.value = value;

        public static implicit operator LongValue(long value)
            => new LongValue(value);

        public static implicit operator long(LongValue doubleValue)
            => doubleValue.value;
    }
}
