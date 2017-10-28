using Android.App;
using Android.Widget;
using Android.OS;

namespace Loanliness
{
    [Activity(Label = "Loanliness", Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

        }
    }
}

