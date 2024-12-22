namespace AmznSellingPartner.Models.Console.Json
{
    using Newtonsoft.Json.Linq;

    using System;
    using System.Collections.Generic;

    internal static class JExtensions
    {
        public static event Action<string, string, JToken> NotImplemented;

        public static string Capitalize(this string value)
        {
            var length = value?.Length ?? 0;

            if (length <= 0)
            {
                return value;
            }
            else if (length <= 1)
            {
                return value.ToUpper();
            }
            else
            {
                return char.ToUpper(value[0]) + value[1..];
            }
        }

        public static IEnumerable<string> ToSummaryRows(this string text)
        {
            var rows = new List<string>();

            foreach (var sentence in text.Split('.'))
            {
                var _sentence = sentence.Trim();

                while (_sentence.Length > 0)
                {
                    if (_sentence.Length <= 100)
                    {
                        rows.Add($"{_sentence}.");

                        break;
                    }

                    var ix = _sentence.IndexOf(' ', 100);

                    if (ix < 100)
                    {
                        rows.Add($"{_sentence}.");

                        break;
                    }

                    var part = _sentence.Substring(0, ix);

                    rows.Add(part);

                    _sentence = _sentence.Substring(ix + 1);
                }
            }

            return rows;
        }

        internal static void NotifyUnhandledDataDetected(string jtype, string jpath, JToken jtoken)
            => NotImplemented?.Invoke(jtype, jpath, jtoken);
    }
}
