using Android.App;
using Android.Content.PM;
using Android.OS;

namespace MauiCorpClient
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Initialization logic here

            // After initialization, before loading the main app, display the splash screen
            //SetContentView(Resource.Layout.splash_layout);

            // Optionally add a delay or wait for an async operation
            Task.Delay(2000); // Simulate a 2-second delay

            // Continue with loading the Blazor app
        }
    }
}