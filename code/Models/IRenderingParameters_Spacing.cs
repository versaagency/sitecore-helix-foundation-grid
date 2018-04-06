using Glass.Mapper.Sc.Configuration.Attributes;

namespace Sitecore.Foundation.Grid.Models
{
    [SitecoreType(TemplateId = Templates.RenderingParameters_Spacing.ID_String, AutoMap = true)]
    public interface IRenderingParameters_Spacing
    {
        ISpacingType MarginTop { get; set; }

        ISpacingType MarginRight { get; set; }

        ISpacingType MarginBottom { get; set; }

        ISpacingType MarginLeft { get; set; }
    }
}
