using Android.App;
using Android.Views;
using Android.Widget;
using FragmentSample.Core.ViewModels.Shakespeare;
using MvvmCross.Droid.Support.V7.Fragging;

namespace FragmentSample.UI.Droid.Views
{
    [Activity]
    public class DetailView
        : MvxFragmentActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.Page_DetailView);
            SetDetailFragmentDataContext();
        }

        private void SetDetailFragmentDataContext()
        {
            var fragment = (DetailFragment)SupportFragmentManager.FindFragmentById(Resource.Id.detail_fragment);
            fragment.ViewModel = ViewModel;
        }
    }
}