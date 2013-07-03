using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Video;
using AForge.Video.DirectShow; 

namespace Webcam.Controller
{
    class Devices
    {
        private static Devices instance;
        private FilterInfoCollection VideoDevices; 
        
        private Devices() { }
        
        public static Devices getInstance() 
        {

            lock (typeof(Devices))
            {
                instance = new Devices(); 
            }

            return instance;
        }
    }
}
