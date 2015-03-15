using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using AForge.Imaging.Filters;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Configuration;
using Webcam.Forms;
using Webcam.Models;
using Webcam.Controller; 

namespace Webcam
{
    public partial class WebcamMain : MetroFramework.Forms.MetroForm
    {
        public List<Photo> Photos = new List<Photo>();
        public FilterInfoCollection VideoCaptureDevices;
        public VideoCaptureDevice CaptureDevice;
        public Bitmap CurrentFrame;
        public int SelectedDevice;
        public AppSettingsReader AppSettings = new AppSettingsReader();
        private CameraFilter cameraFilter; 

        public WebcamMain()
        {
            InitializeComponent();
            
            cameraFilter = new CameraFilter();

            // Events
            speichernToolStripMenuItem1.Click += Save; 
            speichernToolStripMenuItem.Click += Save; 
            beendenToolStripMenuItem.Click += beendenToolStripMenuItem_Click;
            gespiegeltToolStripMenuItem.Click += gespiegeltToolStripMenuItem_Click;
            sepiaToolStripMenuItem.Click += sepiaToolStripMenuItem_Click;
            schwarzWeißToolStripMenuItem.Click += schwarzWeißToolStripMenuItem_Click;
            negativToolStripMenuItem.Click += negativToolStripMenuItem_Click;
        }

         
        private void negativToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cameraFilter.SetInvert(); 
        }

        private void schwarzWeißToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cameraFilter.SetBlackWhite(); 
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cameraFilter.SetSepia(); 
        }

        private void gespiegeltToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cameraFilter.SetMirror(); 
        }


        private void Save(object sender, EventArgs e)
        {
            if (IsCamRunning())
            {
                Image imageToSave = previewBox.Image;
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = @"Jpeg|*.jpg|Png|*.png";

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    imageToSave.Save(saveFile.FileName);
                    Photos.Add(new Photo(saveFile.FileName));
                }
            }

            else
            {
                MessageBox.Show(@"Kamera läuft nicht!");
            }
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void StartCam()
        {
            if (IsCamRunning())
            {
                CaptureDevice.Stop(); 
            }

            SelectedDevice = (int)AppSettings.GetValue("selectedcam", typeof(int));
            CaptureDevice = new VideoCaptureDevice(VideoCaptureDevices[SelectedDevice].MonikerString);
            CaptureDevice.NewFrame += delegate(object o, NewFrameEventArgs args) { captureDevice_NewFrame(o, args); };
            CaptureDevice.Start();
        }

        private void WebcamMain_Load(object sender, EventArgs e)
        {
            VideoCaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (VideoCaptureDevices.Count > 0)
            {
                StartCam(); 
            }

            else
            {
                MessageBox.Show(@"Keine Geräte gefunden", @"Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }

        }

        private void captureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            CurrentFrame = (Bitmap) eventArgs.Frame.Clone();
            CurrentFrame = cameraFilter.SetFilterFor(CurrentFrame); 
            previewBox.Image = CurrentFrame; 
        }

        private void WebcamMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            CaptureDevice.Stop(); 
        }

        private bool IsCamRunning()
        {
            return (CaptureDevice != null && CaptureDevice.IsRunning); 
        }
    }
}
