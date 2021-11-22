using System.Windows;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Unity;
using PrismSample.Lib.Views;
using PrismSample.Lib.ViewModels;
using PrismSample.Lib.Models;

namespace PrismSample.App.Main
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // コンテナに手動でクラスやインスタンスを登録する際に使用する
            containerRegistry.Register<IModel, Model>();
            containerRegistry.Register<IDialogHelper, DialogHelper>();
        }

        protected override void ConfigureViewModelLocator()
        {
            base.ConfigureViewModelLocator();

            ViewModelLocationProvider.Register<MainWindow, MainWindowViewModel>();
            ViewModelLocationProvider.Register<OperandView, OperandViewModel>();
            ViewModelLocationProvider.Register<AnswerView, AnswerViewModel>();
        }
    }
}
