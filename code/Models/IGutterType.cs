using Glass.Mapper.Sc.Configuration.Attributes;

namespace Sitecore.Foundation.Grid.Models
{
    [SitecoreType(TemplateId = "{67AAAB4B-1BB2-43B7-A2CD-CCAEC30E4E07}", AutoMap = true)]

    public interface IGutterType
    {
        string Class { get; set; }
    }
}
