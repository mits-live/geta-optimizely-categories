using Geta.Optimizely.Categories;

namespace AlloyDemoDotNet6.Models.Categories;

[ContentType]
public class AdvancedCategory : CategoryData
{
    [CultureSpecific]
    public virtual XhtmlString MainBody { get; set; }
}
