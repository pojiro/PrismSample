using Prism.Mvvm;
using Reactive.Bindings;

namespace PrismSample.Lib.ViewModels
{
    public class MainWindowsViewModel : BindableBase
    {
        public ReactiveProperty<string> Text { get; } = new ReactiveProperty<string>("Hello, Prism!");
    }
}