namespace AmznSellingPartner
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;

    internal static partial class AmznExtensions
    {
        public static string Capitalize(this string value)
        {
            var _value = string.Empty;

            foreach (var token in NonAlphaNumeric().Split($"{value}"))
            {
                if (string.IsNullOrWhiteSpace(token))
                {
                    continue;
                }

                _value += char.ToUpper(token[0]);

                if (token.Length > 1)
                {
                    _value += token[1..];
                }
            }

            return _value;
        }

        public static string GetReferenceType(this string reference)
            => reference
                ?.Split('/', StringSplitOptions.RemoveEmptyEntries)
                ?.LastOrDefault()
                ?.Capitalize()
                ?? "object";

        [GeneratedRegex("[^a-zA-Z0-9]")]
        internal static partial Regex NonAlphaNumeric();

        public static IEnumerable<string> SplitToLines(this string description)
        {
            var line = description?.Replace('\n', ' ');
            var summary = new List<string>();
            var maxLenght = 90;

            while (line.Length > maxLenght)
            {
                var ix = line.IndexOf(' ', maxLenght);
                ix = Math.Max(ix, maxLenght);
                summary.Add(line[..ix].Trim());
                line = line[ix..].Trim();
            }

            summary.Add(line.Trim());

            return summary;
        }

        internal static string ToModelName(this string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return "UnknownClient";
            }

            var tokens = value
                .Replace("api", string.Empty)
                .Replace("model", string.Empty)
                .Split('-', StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Capitalize());

            return string.Join(string.Empty, tokens);
        }

        internal static string ToClientName(this string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return "UnknownModel";
            }

            return Path
                .GetFileNameWithoutExtension(value)
                .Replace("-", string.Empty)
                .Replace("_", string.Empty)
                .Capitalize();
        }

        internal static string ToEnumMember(this string value)
        {
            value = NonAlphaNumeric().Replace($"{value}", "_");

            if (value.Length == 1)
            {
                value = value.ToUpper();
            }
            else if (value.Length > 1)
            {
                value = $"{char.ToUpper(value[0])}{value[1..]}";
            }

            if ('0' <= value[0] && value[0] <= '9')
            {
                value = $"_{value}";
            }

            return value;
        }
    }
}
