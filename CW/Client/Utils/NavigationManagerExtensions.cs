using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Primitives;

namespace CW.Client.Utils {

    public static class NavigationManagerExtensions {

        public static bool TryGetQueryParameter(this NavigationManager manager, string paramName, out string[] values) {
            var result = QueryHelpers.ParseQuery(manager.ToAbsoluteUri(manager.Uri).Query).TryGetValue(paramName, out StringValues strings);
            values = strings.ToArray();
            return result;
        }

        public static bool TryGetQueryParameter(this NavigationManager manager, string paramName, out string value) {
            var result = TryGetQueryParameter(manager, paramName, out string[] vals);
            value = vals.Length != 0 ? vals[0] : null;
            return result;
        }

    }
}
