using Android.App;

namespace ValueConversion.UI.Droid.Views
{
    [Activity]
    public class StringsView : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.View_Strings);
        }
    }
}