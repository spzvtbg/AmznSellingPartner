namespace AmznSellingPartner.Clients.Values
{
    public class FloatValue
    {
        private float value;

        public FloatValue()
        {

        }

        public FloatValue(float value)
            => this.value = value;

        public static implicit operator FloatValue(float value)
            => new FloatValue(value);

        public static implicit operator float(FloatValue doubleValue)
            => doubleValue.value;
    }
}
