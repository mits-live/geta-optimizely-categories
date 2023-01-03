using Geta.Optimizely.Categories;

namespace AlloyDemoDotNet6.Models.Categories;

[ContentType]
public class NewsCategory : CategoryData
{
    [CultureSpecific]
    public virtual IList<string> TopicKeywords { get; set; }
}
