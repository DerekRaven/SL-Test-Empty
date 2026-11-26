namespace PastaShapesApp.Presentation;

[Uno.Extensions.Reactive.ReactiveBindable(false)]
public partial record PastaShapesModel
{
    public string Heading { get; } = "Every shape, explained";
    public string Intro { get; } = "Eight classics from Italian kitchens, with their origins, the meaning behind their names and the sauces that suit them best.";
    public string CountLabel { get; } = "8 shapes documented";

    public IReadOnlyList<PastaShape> Shapes { get; } = PastaCatalog.All;
}
