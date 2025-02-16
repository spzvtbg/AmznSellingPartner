namespace AmznSellingPartner.Clients.Values
{
    public class DoubleValue
    {
        private double value;

        public DoubleValue()
        {

        }

        public DoubleValue(double value)
            => this.value = value;

        public static implicit operator DoubleValue(double value)
            => new DoubleValue(value);

        public static implicit operator double(DoubleValue doubleValue)
            => doubleValue.value;
    }
}
