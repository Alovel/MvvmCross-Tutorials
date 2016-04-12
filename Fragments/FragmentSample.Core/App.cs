
using FragmentSample.Core.ViewModels;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.IoC;

namespace FragmentSample.Core
{
    public class App
        :  MvxApplication
    { 

        public override void Initialize()
        {
            base.Initialize();
            InitialisePlugins();
            InitaliseServices();
            InitialiseStartNavigation();
        }

        private void InitaliseServices()
        {
            CreatableTypes().EndingWith("Service").AsInterfaces().RegisterAsLazySingleton();
        }

        private void InitialiseStartNavigation()
        {
            RegisterAppStart<HomeViewModel>();
        }

        private void InitialisePlugins()
        {
            // initialise any plugins where are required at app startup
            // e.g. Cirrious.MvvmCross.Plugins.Visibility.PluginLoader.Instance.EnsureLoaded();
        }
    }
}