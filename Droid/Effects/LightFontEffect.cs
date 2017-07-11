using PlatformSpecifics.Droid.Effects;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Widget;
using Android.Graphics;

[assembly: ResolutionGroupName("JimBobBennett")]
[assembly: ExportEffect(typeof(LightFontEffect), nameof(LightFontEffect))]

namespace PlatformSpecifics.Droid.Effects
{
    public class LightFontEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            if (Control is TextView text)
            {
                text.SetTypeface(Typeface.Create("sans-serif-light", TypefaceStyle.Normal), 
                                 TypefaceStyle.Normal);
            }
        }

        protected override void OnDetached()
        {
        }
    }
}
