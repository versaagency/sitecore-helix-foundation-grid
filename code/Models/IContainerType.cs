using Glass.Mapper.Sc.Configuration.Attributes;

namespace Sitecore.Foundation.Grid.Models
{
    [SitecoreType(TemplateId = "{B644C3EB-268B-4638-82B5-C48AE150E9F6}", AutoMap = true)]

    public interface IContainerType
    {
        string Class { get; set; }
    }
}
