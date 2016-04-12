using Android.OS;
using Android.Runtime;
using Android.Views;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.FullFragging.Fragments;

namespace FragmentSample.UI.Droid.Views
{
    [Register("fragmentsample.ui.droid.views.Tab1Fragment")]
    public class Tab1Fragment : MvxFragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container,
                                     Bundle savedInstanceState)
        {
            var ignored = base.OnCreateView(inflater, container, savedInstanceState);
            return this.BindingInflate(Resource.Layout.tabs_1, null);
        }
    }
}