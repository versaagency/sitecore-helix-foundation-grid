using System.Web.Mvc;
using Sitecore.Foundation.Grid.Models;

namespace Sitecore.Foundation.Grid.Extensions
{
    public static class HtmlHelperExtensions
    {
        public static string SpacingClasses(this HtmlHelper htmlHelper, IRenderingParameters_Spacing parameters)
        {
            if (parameters == null)
                return string.Empty;

            var classes = new[]
            {
                GetSizeClass(parameters.MarginTop, "margin", "top"),
                GetSizeClass(parameters.MarginRight, "margin", "right"),
                GetSizeClass(parameters.MarginBottom, "margin", "bottom"),
                GetSizeClass(parameters.MarginLeft, "margin", "left")
            };

            return string.Join(" ", classes);
        }

        private static string GetSizeClass(ISpacingType spacingType, string type, string direction)
        {
            if (spacingType != null && !string.IsNullOrEmpty(spacingType.Size))
            {
                return $"{type}-{direction}--{spacingType.Size}";
            }

            return string.Empty;
        }
    }
}
