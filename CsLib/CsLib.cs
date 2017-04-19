using System;

namespace FcMixed {
    public static class CsLib {
        public static String csLibFn() {
            var now = System.DateTimeOffset.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ");
            return $"calling into C# {now}";
        }
    }
}