using Sitecore.Data;

namespace Sitecore.Foundation.Grid
{
    public static class Templates
    {
        public struct RenderingParameters_Cell
        {
            public const string ID_String = "{40D4C470-3A45-4B1B-8C8B-EBA34D7F5E38}";
            public static readonly ID ID = new ID(ID_String);
        }

        public struct RenderingParameters_Grid
        {
            public const string ID_String = "{A405650C-69C5-4811-B8B3-F39EA9C1A14F}";
            public static readonly ID ID = new ID(ID_String);
        }

        public struct RenderingParameters_Spacing
        {
            public const string ID_String = "{F4862D8A-EF6A-411C-AB9D-ABFE5ED83BA7}";
            public static readonly ID ID = new ID(ID_String);
        }
    }
}
