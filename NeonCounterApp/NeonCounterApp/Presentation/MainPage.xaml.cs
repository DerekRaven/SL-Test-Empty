namespace NeonCounterApp.Presentation;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.InitializeComponent();

        // For Hot Design Previews (which bypass Navigation). At runtime the template's
        // ViewMap<MainPage, MainModel> wires the DataContext; replacing this is expected.
        this.DataContext = new MainModel();
    }

    private void Increment_Click(object sender, RoutedEventArgs e)
    {
        (DataContext as MainModel)?.Increment();
    }

    private void Decrement_Click(object sender, RoutedEventArgs e)
    {
        (DataContext as MainModel)?.Decrement();
    }

    private void Reset_Click(object sender, RoutedEventArgs e)
    {
        (DataContext as MainModel)?.Reset();
    }

    private void Step_Click(object sender, RoutedEventArgs e)
    {
        (DataContext as MainModel)?.CycleStep();
    }
}
