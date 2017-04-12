using Xamarin.Forms;
using AppCreditas.Droid;
using Xamarin.Forms.Platform.Android;
using Android.Graphics;

[assembly: ExportRenderer(typeof(Label), typeof(LabelCustom))]
namespace AppCreditas.Droid
{
    public class LabelCustom : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Typeface font = Typeface.CreateFromAsset(Context.Assets, "fonts/AmpleSoftLight.otf");
                Control.SetTypeface(font, TypefaceStyle.Normal);

            }
        }
    }
}