using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using Navigation.Core.ViewModels;

namespace Navigation.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<MainViewModel>());
        }
    }
}