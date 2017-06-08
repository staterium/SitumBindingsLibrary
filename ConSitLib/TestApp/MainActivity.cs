using Android.App;
using Android.Widget;
using Android.OS;
using Com.Example;
using ES.Situm.Sdk;

namespace TestApp
{
    [Activity(Label = "TestApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);

            //SitumSdk.Init(this);
            //SitumSdk.Configuration().SetApiKey("cobus.lombard@gmail.com", "QMqlz97CLOxwYyxHBVJlpZSklgyVkLPy");

            //SitumSdk.CommunicationManager().FetchBuildings(new ES.Situm.Sdk.Utils.Handler());
            /*Helpers h = new Helpers();
            h.SitumInit(Application.Context);
            h.SitumSetApiKey("cobus.lombard@gmail.com", "QMqlz97CLOxwYyxHBVJlpZSklgyVkLPy");

            if (h.SitumFetchBuildings())
            {
                var b = h.AllBuildings;
            }
            else
            {
                string s = h.ErrorMessage;
            }*/

            SitumSdk.Init(this);
            SitumSdk.Configuration().SetApiKey("cobus.lombard@gmail.com", "QMqlz97CLOxwYyxHBVJlpZSklgyVkLPy");
            var i = SitumSdk.Configuration();
        }
    }
}

