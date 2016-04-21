using Android.App;

namespace ValueConversion.UI.Droid.Views
{
    [Activity]
    public class ColorsView : MvxAcitvity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.View_Colors);
        }
    }
}