namespace PastaShapesApp.Presentation;

public partial record PastaShape(
    string Id,
    string Name,
    string Meaning,
    string Category,
    string Origin,
    string Description,
    string PairsWith,
    string CookTime,
    string ImageUrl);

public static class PastaCatalog
{
    public static IReadOnlyList<PastaShape> All { get; } = new[]
    {
        new PastaShape(
            "spaghetti", "Spaghetti", "\"Little strings\"", "Long", "Southern Italy",
            "The icon of Italian cooking: thin, round strands that twirl neatly around a fork and carry oil-based and tomato sauces with ease.",
            "Carbonara, aglio e olio, light tomato sauce", "9-11 min",
            "https://images.pexels.com/photos/546945/pexels-photo-546945.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=650&w=940"),
        new PastaShape(
            "penne", "Penne", "\"Quills\"", "Tubular", "Liguria",
            "Short tubes cut on a diagonal, resembling a quill pen. The ridged version, penne rigate, grips chunky sauces on the outside while sauce pools inside.",
            "Arrabbiata, vodka sauce, baked dishes", "11-13 min",
            "https://images.pexels.com/photos/1438672/pexels-photo-1438672.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=650&w=940"),
        new PastaShape(
            "rigatoni", "Rigatoni", "\"Large ridged ones\"", "Tubular", "Rome",
            "Wide, deeply ridged tubes with straight-cut ends. Sturdy enough for hearty meat ragu and rich, baked casseroles.",
            "Amatriciana, Bolognese ragu, sausage sauces", "12-14 min",
            "https://images.pexels.com/photos/8108206/pexels-photo-8108206.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=650&w=940"),
        new PastaShape(
            "fusilli", "Fusilli", "\"Little spindles\"", "Twisted", "Southern Italy",
            "Tight corkscrew spirals that trap sauce in every groove. Traditionally spun by hand around a thin rod before drying.",
            "Pesto, pasta salads, creamy vegetable sauces", "9-11 min",
            "https://images.pexels.com/photos/18312137/pexels-photo-18312137.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=650&w=940"),
        new PastaShape(
            "farfalle", "Farfalle", "\"Butterflies\"", "Shaped", "Lombardy and Emilia-Romagna",
            "Pinched bow-tie shapes with a tender, frilled edge and a slightly chewier center. Pretty in the bowl and forgiving to cook.",
            "Smoked salmon cream, summer vegetables, cold salads", "10-12 min",
            "https://images.pexels.com/photos/4039713/pexels-photo-4039713.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=650&w=940"),
        new PastaShape(
            "orecchiette", "Orecchiette", "\"Little ears\"", "Shaped", "Puglia",
            "Small concave discs shaped by thumb pressure. Their cup-like hollows scoop up bits of greens, sausage and olive oil.",
            "Broccoli rabe and sausage, cherry tomatoes, ricotta salata", "10-12 min",
            "https://images.pexels.com/photos/36597377/pexels-photo-36597377.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=650&w=940"),
        new PastaShape(
            "tortellini", "Tortellini", "\"Little pies\"", "Stuffed", "Bologna",
            "Ring-shaped parcels folded around a filling of meat or cheese, said to be modeled on a navel. Best served simply so the filling shines.",
            "Capon broth, butter and sage, light cream sauce", "4-6 min",
            "https://images.pexels.com/photos/4039607/pexels-photo-4039607.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=650&w=940"),
        new PastaShape(
            "lasagna", "Lasagne", "\"Cooking pot\"", "Sheet", "Naples and Emilia-Romagna",
            "Broad, flat sheets layered with sauce and cheese, then baked until golden. One of the oldest pasta shapes still made today.",
            "Ragu and besciamella, ricotta and spinach", "8-10 min",
            "https://images.pexels.com/photos/5724557/pexels-photo-5724557.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=650&w=940"),
    };
}
