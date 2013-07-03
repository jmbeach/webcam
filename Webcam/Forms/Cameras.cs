using System;
using System.Globalization;
using System.Windows.Forms;
using System.Configuration;
using AForge.Video.DirectShow;
using System.Collections.Specialized; 

namespace Webcam.Forms
{
    public partial class Cameras : Form
    {

        NameValueCollection appSettings = ConfigurationManager.AppSettings;

        readonly WebcamMain _mainForm; 
        
        public Cameras(WebcamMain mainForm)
        {
            this._mainForm = mainForm; 
            InitializeComponent();
        }

        private void Cameras_Load(object sender, EventArgs e)
        {
            
            cMirrorCam.Checked = (bool) _mainForm.AppSettings.GetValue("mirrorcam", typeof(bool)); 

            foreach (FilterInfo device in _mainForm.VideoCaptureDevices)
            {
                devices.Items.Add(device.Name); 
            }

            devices.SelectedIndex = _mainForm.SelectedDevice; 
        }

        private void bSaveSettings_Click(object sender, EventArgs e)
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings.Remove("selectedcam");
                config.AppSettings.Settings.Remove("mirrorcam");
                config.AppSettings.Settings.Add("selectedcam", devices.SelectedIndex.ToString(CultureInfo.InvariantCulture));
                config.AppSettings.Settings.Add("mirrorcam", cMirrorCam.Checked.ToString());
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                _mainForm.StartCam();

                this.Close(); 
            }

            catch (ConfigurationErrorsException exception)
            {
                MessageBox.Show(@"Fehler beim Speichern der Einstellungen" + exception.StackTrace); 
            }

        }
    }
}
