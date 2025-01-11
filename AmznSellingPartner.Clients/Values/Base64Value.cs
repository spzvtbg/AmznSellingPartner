namespace AmznSellingPartner.Clients.Values
{
    using System;

    public class Base64Value
    {
        private readonly byte[] buffer;

        private Base64Value(byte[] buffer) 
            => this.buffer = buffer;

        public static implicit operator Base64Value(byte[] buffer)
            => new Base64Value(buffer);

        public static implicit operator Base64Value(string value)
            => Convert.FromBase64String(value);

        public static implicit operator byte[](Base64Value base64Value)
            => base64Value.buffer;

        public static implicit operator string(Base64Value base64Value)
            => Convert.ToBase64String(base64Value);
    }
}
