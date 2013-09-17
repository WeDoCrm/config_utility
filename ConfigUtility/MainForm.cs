using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Elegant.Ui.Samples.ControlsSample.Properties;

namespace Elegant.Ui.Samples.ControlsSample
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            //This call is required by the Windows Form Designer.
            Elegant.Ui.RibbonLicenser.LicenseKey = "E644-DB48-BFFB-CA0C-53D2-4F3F-C938-C3EF";

            SetStyle(
                ControlStyles.UserPaint,
                true);

            InitializeComponent();

            //if(SystemFonts.MenuFont.FontFamily.Name == "Segoe UI")
            //    Font = SystemFonts.MenuFont;

            //SkinManager.LoadEmbeddedTheme(EmbeddedTheme.System , Product.Common);
            FirewallClientStatPageToggleButton.Tag = typeof(FirewallClientStatPage);
            FirewallServerStatPageToggleButton.Tag = typeof(FirewallServerStatPage);

            ControlsNavigationBar.PressedToggleButtonChanged += ControlsNavigationBar_PressedToggleButtonChanged;
            
            ControlsNavigationBar.PerformLayout();

            DisplayCurrentSamplePage();
            SetMenuByMode(true);
        }

        public static void SetMonospaceFont(System.Windows.Forms.Control control)
        {
            const string modernFontName = "Consolas";
            const string classicFontName = "Courier New";

            if (SystemInfo.IsWindowsXPOrHigher && SystemInformation.FontSmoothingType == 2) //AA is on
            {
                Font modernFont = TryToGetFont(modernFontName, control.Font.Size);
                if (modernFont != null)
                {
                    control.Font = modernFont;
                    return;
                }
            }

            Font font = TryToGetFont(classicFontName, control.Font.Size);
            if (font != null)
                control.Font = font;
        }

        private static Font TryToGetFont(string fontName, float size)
        {
            FontFamily[] families = FontFamily.Families;
            Font font = null;

            foreach (FontFamily family in families)
            {
                if (family.Name == fontName)
                {
                    font = new Font(new FontFamily(fontName), size);
                    break;
                }
            }

            return font;
        }


        private readonly Dictionary<Type, UserControl> _controlsSamplePages = new Dictionary<Type, UserControl>();

        private UserControl GetControlsSamplePage(Type type)
        {
            if(type == null)
                throw new ArgumentNullException("type");

            if(!type.IsSubclassOf(typeof(UserControl)))
                return null;

            UserControl samplePage;
            if (_controlsSamplePages.TryGetValue(type, out samplePage))
                return samplePage;

            samplePage = (UserControl)Activator.CreateInstance(type);

            _controlsSamplePages.Add(type, samplePage);

            return samplePage;
        }

        private void ControlsNavigationBar_PressedToggleButtonChanged(object sender, NavigationBarPressedToggleButtonChangedEventArgs e)
        {
            DisplayCurrentSamplePage();
        }

        private void DisplayCurrentSamplePage()
        {
            UserControl currentSamplePage = null;

            if(ControlsNavigationBar.PressedToggleButton != null)
            {
                Type type = ControlsNavigationBar.PressedToggleButton.Tag as Type;
                if (type != null)
                    currentSamplePage = GetControlsSamplePage(type);
            }

            ControlsSamplePageContainer.ControlsSamplePage = currentSamplePage;
        }

		private readonly Theme _windows7 = new Theme("Windows7", Resources.Windows7);
		private readonly Theme _system = new Theme("System", Resources.System);

        private void SetMenuByMode(bool isServer) {
            FirewallClientStatPageToggleButton.Enabled = (!isServer);
            FirewallServerStatPageToggleButton.Enabled = isServer;
            FirewallClientStatPageToggleButton.Pressed = (!isServer);
            FirewallServerStatPageToggleButton.Pressed = isServer;
        }

        private void RadioButtonServerMode_Click(object sender, EventArgs e)
        {
            SetMenuByMode(RadioButtonServerMode.Checked);
        }

    }
}