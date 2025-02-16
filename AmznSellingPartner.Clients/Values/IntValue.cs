namespace AmznSellingPartner.Clients.Values
{
    public class IntValue
    {
        private int value;

        public IntValue()
        {

        }

        public IntValue(int value)
            => this.value = value;

        public static implicit operator IntValue(int value)
            => new IntValue(value);

        public static implicit operator int(IntValue doubleValue)
            => doubleValue.value;
    }
}
