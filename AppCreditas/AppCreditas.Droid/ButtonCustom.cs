using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using AppCreditas.Droid;
using Android.Graphics;

[assembly: ExportRenderer(typeof(Button), typeof(ButtonCustom))]
namespace AppCreditas.Droid
{
    public class ButtonCustom : ButtonRenderer
    {



        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
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