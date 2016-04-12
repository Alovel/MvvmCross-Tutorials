using Android.OS;
using Android.Runtime;
using Android.Views;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.FullFragging.Fragments;


namespace FragmentSample.UI.Droid.Views
{
    [Register("fragmentsample.ui.droid.views.Tab2Fragment")]
    public class Tab2Fragment : MvxFragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container,
                                          Bundle savedInstanceState)
        {
            var ignored = base.OnCreateView(inflater, container, savedInstanceState);
            return this.BindingInflate(Resource.Layout.tabs_2, null);
        }
    }
}