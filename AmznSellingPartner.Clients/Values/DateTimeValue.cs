namespace AmznSellingPartner.Clients.Values
{
    using System;

    public class DateTimeValue
    {
        private DateTime dateTime;

        public DateTimeValue(DateTime dateTime)
            => this.dateTime = dateTime;

        public static implicit operator DateTimeValue(string value)
            => new DateTimeValue(DateTime.TryParse(value, out var dateTime) ? dateTime : DateTime.MinValue);

        public static implicit operator DateTime(DateTimeValue dateTimeValue)
            => dateTimeValue.dateTime;

        public static implicit operator string(DateTimeValue dateTimeValue)
            => dateTimeValue.dateTime.ToString();
    }
}
