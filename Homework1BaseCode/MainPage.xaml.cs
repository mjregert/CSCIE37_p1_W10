using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Globalization; // Provides access to Globalization settings APIs
using Windows.System.UserProfile; // Provides access to user preference setting APIs

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Homework1BaseCode
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            // Add resource file and get the display name
            var loader = new Windows.ApplicationModel.Resources.ResourceLoader();

            //Globalization Preferences
            chosen_lang.Text = loader.GetString("chosen_lang");
            chosen_lang.Text += ": "+ System.Globalization.CultureInfo.CurrentCulture + "\n";

            lang_details.Text = loader.GetString("display_name");
            lang_details.Text += ": " +  System.Globalization.CultureInfo.CurrentCulture.EnglishName + "\n";

            /*home_region.Text = loader.GetString("home_region");
            home_region.Text += ": " + System.Globalization.RegionInfo.CurrentRegion + "\n";

            calendar_setting.Text = loader.GetString("calendar_setting");
            calendar_setting.Text += ": " + System.Globalization.CultureInfo.CurrentUICulture.Calendar.GetType().Name + "\n";

            clock_setting.Text = loader.GetString("clock_setting");
            clock_setting.Text += ": " + System.Globalization.CultureInfo.CurrentUICulture.DateTimeFormat.PMDesignator + "\n";

            week_start.Text = loader.GetString("week_start");
            week_start.Text += ": " + System.Globalization.CultureInfo.CurrentUICulture.DateTimeFormat.FirstDayOfWeek + "\n";

            //Language Specifics
            lang_details.Text = "<user top language display name>: <user top language details> \n";

            //Geo Region Specifics
            geo_details.Text = "<geographic region display name>: <geographic region details> \n";
            */

        }
    }
}