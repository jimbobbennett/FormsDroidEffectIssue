using PlatformSpecifics.iOS.Effects;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using UIKit;

[assembly: ResolutionGroupName("JimBobBennett")]
[assembly: ExportEffect(typeof(LightFontEffect), nameof(LightFontEffect))]

namespace PlatformSpecifics.iOS.Effects
{
    public class LightFontEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            if (Control is UILabel label)
            {
                label.Font = UIFont.SystemFontOfSize(label.Font.PointSize, 
                                                     UIFontWeight.UltraLight);
            }
            else if (Control is UITextField textField)
            {
                textField.Font = UIFont.SystemFontOfSize(textField.Font.PointSize, 
                                                         UIFontWeight.UltraLight);
            }
        }

        protected override void OnDetached()
        {
        }
    }
}
