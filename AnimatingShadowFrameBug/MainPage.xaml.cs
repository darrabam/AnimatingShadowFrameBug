using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AnimatingShadowFrameBug
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnFrameClicked(object sender, EventArgs e)
        {
            var frame = (Frame)sender;
            var bounds = frame.Bounds;
            bounds.Y += 25;
            await frame.LayoutTo(bounds, 500, Easing.CubicInOut);
        }
    }
}
