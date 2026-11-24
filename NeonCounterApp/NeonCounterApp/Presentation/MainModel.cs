using System.ComponentModel;

namespace NeonCounterApp.Presentation;

[Uno.Extensions.Reactive.ReactiveBindable(false)]
public partial record MainModel : INotifyPropertyChanged
{
    private static readonly int[] Steps = { 1, 5, 10 };

    private int _count;
    private int _peak;
    private int _stepIndex;

    public event PropertyChangedEventHandler? PropertyChanged;

    public string Title { get; } = "NEON COUNTER";

    public string Subtitle { get; } = "TAP TO CHARGE THE GRID";

    public string CountText => _count.ToString();

    public string PeakText => _peak.ToString();

    public string StepText => $"STEP +{Steps[_stepIndex]}";

    public string StatusText => _count switch
    {
        0 => "SYSTEM IDLE",
        < 0 => "REVERSE POLARITY",
        < 25 => "POWERING UP",
        < 75 => "ONLINE",
        _ => "OVERLOAD",
    };

    public void Increment()
    {
        _count += Steps[_stepIndex];
        if (_count > _peak)
        {
            _peak = _count;
        }

        Notify();
    }

    public void Decrement()
    {
        _count -= Steps[_stepIndex];
        Notify();
    }

    public void Reset()
    {
        _count = 0;
        Notify();
    }

    public void CycleStep()
    {
        _stepIndex = (_stepIndex + 1) % Steps.Length;
        Notify();
    }

    private void Notify()
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CountText)));
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PeakText)));
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(StepText)));
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(StatusText)));
    }
}
