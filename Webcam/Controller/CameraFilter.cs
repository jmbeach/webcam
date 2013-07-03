using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Imaging.Filters;

namespace Webcam.Controller
{
    internal class CameraFilter
    {

        #region Filters 

        public bool BlackWhite = false;
        public bool Sepia = false;
        public bool Invert = false;
        public bool Mirror = false;

        #endregion
        
        #region Setters and Getters 

        public bool SetBlackWhite()
        {
            return this.BlackWhite != this.BlackWhite;
        }

        public bool SetSepia()
        {
            return this.Sepia != this.Sepia;
        }

        public bool SetInvert()
        {
            return this.Invert != this.Invert;
        }

        public bool SetMirror()
        {
            return this.Mirror != this.Mirror;
        }

        #endregion



        public Bitmap SetFilterFor(Bitmap frame)
        {
            if (frame != null)
            {
                // Filter
                if (this.Mirror) frame.RotateFlip(RotateFlipType.RotateNoneFlipNone);
                if (!this.Mirror) frame.RotateFlip(RotateFlipType.RotateNoneFlipX);

                if (this.Sepia)
                {
                    Sepia sepiaFilter = new Sepia();
                    frame = sepiaFilter.Apply(frame);
                }

                if (this.BlackWhite)
                {
                    Grayscale grayscale = new Grayscale(0.4, 0.2, 0.4);
                    frame = grayscale.Apply(frame);
                }

                if (this.Invert)
                {
                    Invert invert = new Invert();
                    frame = invert.Apply(frame);
                }
            }

            return frame; 
        }
    }
}
