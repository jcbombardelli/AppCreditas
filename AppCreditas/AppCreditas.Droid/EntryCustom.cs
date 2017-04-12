using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using AppCreditas.Droid;
using Android.Graphics;

[assembly: ExportRenderer(typeof(Entry), typeof(EntryCustom))]
namespace AppCreditas.Droid
{
    public class EntryCustom : EntryRenderer
    {



        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                //Control.SetBackgroundColor(global::Android.Graphics.Color.LightGreen);
                //TextView textview = (TextView)Control.Text;
                Typeface font = Typeface.CreateFromAsset(Context.Assets, "fonts/AmpleSoftLight.otf");
                Control.SetTypeface(font, TypefaceStyle.Normal);

            }
        }
    }
}