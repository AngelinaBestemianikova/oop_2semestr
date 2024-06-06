using System.Windows;
using System.Windows.Controls;

namespace lab4_5
{
     public class FancyButton : Button
    {
        static FancyButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FancyButton), new FrameworkPropertyMetadata(typeof(FancyButton)));
        }
    }
}
