using System;
using Plugin.BluetoothLE;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using Android.Widget;
using Xamarin.Forms;
using Plugin.BLE;
using IAdapter = Plugin.BluetoothLE.IAdapter;
using Adapter = Plugin.BluetoothLE.Adapter;

namespace SnackAutomat.Droid
{

    [Activity(Label = "SnackAutomat", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {


        protected override void OnCreate(Bundle savedInstanceState)
        {
            DependencyService.Register<IAdapter, Adapter>();


              /* //-----USING-------
               var ble = CrossBluetoothLE.Current;
               var adapter = CrossBluetoothLE.Current.Adapter;


               //-----BLUETOTH STATUS-----
               var state = ble.State;
               ble.StateChanged += (s, e) =>
               {
                   Console.WriteLine($"The bluetooth state changed to {e.NewState}");
               };

               //--------IADAPTER-------
               adapter.DeviceDiscovered += (s, a) => deviceListPopUp.Add(a.Device);
               await adapter.StartScanningForDevicesAsync();*/



            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
        
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }



    }
}