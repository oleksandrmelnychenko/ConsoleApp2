using ChoETL;
using System.Text.RegularExpressions;

namespace car.id.server.Helpers {
    public static class ValidationHelper {

        public const string ALLOW_SOME_SYMBOLS = @"^[a-zA-Z\s\-]*$";

        public static bool HasDigit(string value) {
            bool hasDigit = false;
            foreach (var c in value) {
                if (char.IsDigit(c)) {
                    hasDigit = true;
                }
            }
            return hasDigit;
        }

        public static bool HasSomeSymbols(string value) {
            if (value.IsNullOrEmpty()) {
                return false;
            }

            var regex = new Regex(ALLOW_SOME_SYMBOLS);
            return regex.IsMatch(value);
        }

    }
}
