using Glass.Mapper.Sc.Configuration.Attributes;

namespace Sitecore.Foundation.Grid.Models
{
    /// <remarks>
    /// Models the parameters that a Foundation cell can have
    /// <see cref="https://foundation.zurb.com/sites/docs/xy-grid.html#basics"/>
    /// </remarks>
    /// <summary/>
    [SitecoreType(TemplateId = Templates.RenderingParameters_Cell.ID_String, AutoMap = true)]
    public interface IRenderingParameters_Cell
    {
        string SmallSize { get; set; }

        string MediumSize { get; set; }

        string LargeSize { get; set; }

        bool StrokeTop { get; set; }

        bool StrokeRight { get; set; }

        bool StrokeBottom { get; set; }

        bool StrokeLeft { get; set; }

        string VerticalAlignment { get; set; }
    }
}
