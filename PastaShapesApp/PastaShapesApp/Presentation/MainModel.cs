namespace PastaShapesApp.Presentation;

[Uno.Extensions.Reactive.ReactiveBindable(false)]
public partial record MainModel
{
    public string Title { get; } = "The Pasta Shape Handbook";
    public string Tagline { get; } = "A field guide to Italy's most beloved shapes: where they come from, how they got their names, and the sauces they were made for.";
    public string HeroImageUrl { get; } = "https://images.pexels.com/photos/8964276/pexels-photo-8964276.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=650&w=940";
    public string ShapeCountLabel { get; } = "8 shapes";
    public string FamilyCountLabel { get; } = "6 families";
    public string RegionCountLabel { get; } = "7 regions";
    public string FeaturedHeading { get; } = "Featured shapes";
    public string FamiliesIntro { get; } = "Pasta is grouped by form. Each family behaves differently in the pot and on the plate.";

    public IReadOnlyList<string> Families { get; } = new[]
    {
        "Long", "Tubular", "Twisted", "Shaped", "Stuffed", "Sheet"
    };

    public IReadOnlyList<PastaShape> Featured { get; } = new[]
    {
        PastaCatalog.All[0],
        PastaCatalog.All[1],
        PastaCatalog.All[4],
        PastaCatalog.All[6],
    };
}
