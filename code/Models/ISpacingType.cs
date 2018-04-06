using Glass.Mapper.Sc.Configuration.Attributes;

namespace Sitecore.Foundation.Grid.Models
{
    [SitecoreType(TemplateId = "{9DB86ADB-BAED-471F-A19D-23AA9573562E}", AutoMap = true)]
    public interface ISpacingType
    {
        string Size { get; set; }
    }
}
