namespace AmznSellingPartner.Clients.Values
{
    using System;

    public class CsvValue<T>
    {
        private readonly T[] values;

        private CsvValue(string[] strings)
        {
            var type = typeof(T);
            var length = strings.Length;
            this.values = new T[length];

            for (var i = 0; i < length; i++)
            {
                var _string = strings[i];

                if (!string.IsNullOrEmpty(_string) && Convert.ChangeType(_string, type) is T value)
                {
                    this.values[i] = value;
                }
            }
        }

        public static implicit operator CsvValue<T>(string value) 
            => new CsvValue<T>(value?.Split(',') ?? []);

        public static implicit operator T[](CsvValue<T> csv)
            => csv.values;
    }
}
