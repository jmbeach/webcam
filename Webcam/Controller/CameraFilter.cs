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
            return BlackWhite = !BlackWhite;
        }

        public bool SetSepia()
        {
            return Sepia = !Sepia;
        }

        public bool SetInvert()
        {
            return Invert = !Invert;
        }

        public bool SetMirror()
        {
            return Mirror = !Mirror;
        }

        #endregion

        #region Operations

        public Bitmap SetFilterFor(Bitmap frame)
        {
            Bitmap newFrame = frame;

            if (newFrame != null)
            {
                // Filter
                if (Mirror) newFrame.RotateFlip(RotateFlipType.RotateNoneFlipNone);
                if (Mirror) newFrame.RotateFlip(RotateFlipType.RotateNoneFlipX);

                if (Sepia)
                {
                    Sepia sepiaFilter = new Sepia();
                    newFrame = sepiaFilter.Apply(newFrame);
                }

                if (BlackWhite)
                {
                    Grayscale grayscale = new Grayscale(0.4, 0.2, 0.4);
                    newFrame = grayscale.Apply(newFrame);
                }

                if (Invert)
                {
                    Invert invert = new Invert();
                    newFrame = invert.Apply(newFrame);
                }
            }

            return newFrame;
        }

        #endregion

    }
}
