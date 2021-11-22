using Prism.Events;
using Prism.Mvvm;
using PrismSample.Lib.Models;
using Reactive.Bindings;
using Unity;

namespace PrismSample.Lib.ViewModels
{
    public class AnswerViewModel : BindableBase
    {
        [Dependency]
        public IModel Model { get; set; }

        public ReactiveProperty<string> Answer { get; }

        public ReactiveCommand<object> ShowDialogCommand { get; }

        public AnswerViewModel(IEventAggregator eventAggregator)
        {
            Answer = new ReactiveProperty<string>("4");

            eventAggregator
                .GetEvent<PubSubEvent<double>>()
                .Subscribe(CalculateAnswer);
        }

        private void CalculateAnswer(double operand)
        {
            Answer.Value = Model.Calculate(operand).ToString();
        }
    }
}