using Glass.Mapper.Sc.Configuration.Attributes;

namespace Sitecore.Foundation.Grid.Models
{
    /// <remarks>
    /// Models the parameters that a Foundation grid can have
    /// <see cref="https://foundation.zurb.com/sites/docs/xy-grid.html#xy-grid-basics"/>
    /// </remarks>
    /// <summary/>
    [SitecoreType(TemplateId = Templates.RenderingParameters_Grid.ID_String, AutoMap = true)]
    public interface IRenderingParameters_Grid
    {
        IContainerType ContainerType { get; set; }

        IGutterType GutterType { get; set; }

        string CellAlignment { get; set; }
    }
}
