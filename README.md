# PrismSample

[【改訂版】PrismとReactivePropertyで簡単MVVM！](https://qiita.com/hiki_neet_p/items/e04b5ac692aa18df0968)をなぞり、MVVM, Prism, ReactivePropertyを学ぶリポジトリ

## .net バージョン

.net6

## プロジェクト群の作成

PowerShellで以下を実行

```
# ディレクトリの作成
> mkdir PrismSample
> cd PrismSample

# プロジェクト群の作成
> dotnet new sln
> dotnet new wpf -o PrismSample.App.Main
> dotnet new classlib -o PrismSample.Lib.Views
> dotnet new classlib -o PrismSample.Lib.ViewModels
> dotnet new classlib -o PrismSample.Lib.Models

# ソリューションへの追加
> dotnet sln add .\PrismSample.App.Main\ .\PrismSample.Lib.Views\ .\PrismSample.Lib.ViewModels\ .\PrismSample.Lib.Models\

# プロジェクト参照の追加
> dotnet add .\PrismSample.App.Main\ reference .\PrismSample.Lib.Views\
> dotnet add .\PrismSample.App.Main\ reference .\PrismSample.Lib.ViewModels\
> dotnet add .\PrismSample.Lib.ViewModels\ reference .\PrismSample.Lib.Views\
> dotnet add .\PrismSample.Lib.ViewModels\ reference .\PrismSample.Lib.Models\

# パッケージの追加
> dotnet add .\PrismSample.App.Main\ package Prism.Unity
> dotnet add .\PrismSample.Lib.Views\ package Prism.Unity
> dotnet add .\PrismSample.Lib.ViewModels\ package Prism.Unity
> dotnet add .\PrismSample.Lib.ViewModels\ package ReactiveProperty
```
