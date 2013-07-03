using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using AForge.Video;
using AForge.Video.DirectShow;

namespace Webcam.Tests
{
    [TestFixture]
    public class Kameratest
    {

        [Test]
        public void PositiveTest()
        {
            int i = 7;
            int x = 7; 

            Assert.AreEqual(i, x);
        }

        [Test]
        public void SystemHasCamerasAvailable()
        {
            FilterInfoCollection videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            Assert.GreaterOrEqual(1, videoDevices.Count);
        }

        [Test]
        public void CameraCanRun()
        {
            FilterInfoCollection videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            VideoCaptureDevice capture = new VideoCaptureDevice(videoDevices[0].MonikerString);
            capture.Start();

            Assert.IsNotNull(capture);
            Assert.IsTrue(capture.IsRunning);
        }

        [Test]
        public void CameraCanStop()
        {
            FilterInfoCollection videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            VideoCaptureDevice capture = new VideoCaptureDevice(videoDevices[0].MonikerString);
            capture.Start();

            capture.Stop();
            Assert.IsFalse(capture.IsRunning);
        }
    }
}
