using Android.App;

namespace ValueConversion.UI.Droid.Views
{
    [Activity]
    public class HomeView : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.View_Home);
        }
    }
}