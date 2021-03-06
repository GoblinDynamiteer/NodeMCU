﻿namespace drawDisplay
{
    class Display
    {
        static public int Width = 128;
        static public int Height = 64;

        private Pixel[] pixels;
        private XBMByte[] xbmArray;

        /* Constructor */
        public Display()
        {
            pixels = new Pixel[Width * Height]; // 8192
            xbmArray = new XBMByte[Width * Height / 8]; // 1024

            InitPixels();
            InitBytes();

        }

        /* Set pixel state */
        public void SetPixel(bool state, int x, int y)
        {
            for (int i = 0; i < pixels.Length; i++)
            {
                if (x == pixels[i].X && y == pixels[i].Y)
                {
                    pixels[i].SetState(state);
                    break;
                }
            }
        }

        /* Reset pixels / display data */
        public void Reset()
        {
            for (int i = 0; i < pixels.Length; i++)
            {
                pixels[i].SetState(false);
            }

            for (int i = 0; i < xbmArray.Length; i++)
            {
                xbmArray[i].Reset();
            }

        }

        #region initializers

        void InitPixels()
        {
            int i = 0;
            int shift = 0;

            for (int y = 1; y <= Height; y++)
            {
                for (int x = 1; x <= Width; x++)
                {
                    pixels[i] = new Pixel(x, y, i++, shift++, false);
                    

                    if (i > Width * Height)
                    {
                        break;
                    }

                    if (shift > 7)
                    {
                        shift = 0;
                        
                    }
                }
            }
        }

        void InitBytes()
        {
            int pixelIndex = 0;

            for (int i = 0; i < xbmArray.Length; i++)
            {
                xbmArray[i] = new XBMByte();

                for (int j = 0; j < 8; j++)
                {
                    xbmArray[i].AddPixel(pixels[pixelIndex++]);
                }
                
            }
        }

        #endregion

        #region pixeldata
        public int GetNumberOfPixels()
        {
            return pixels.Length;
        }

        public string PixelToString(int index)
        {
            return pixels[index].ToString();
        }

        #endregion

        #region xbmdata

        public int GetNumberOfXBMBytes()
        {
            return xbmArray.Length;
        }

        public string XBMArrayToString(int index)
        {
            return xbmArray[index].ToString();
        }

        /* Generates byte array */
        public byte[] GenerateXBMImage()
        {
            byte[] array = new byte[xbmArray.Length];

            for (int i = 0; i < xbmArray.Length; i++)
            {
                array[i] = (byte)xbmArray[i].GetValue();
            }

            return array;
        }

        #endregion

    }

    /* Holds 8 pixels each, for calculating each byte in
     * XBitMap */
    class XBMByte
    {
        Pixel[] pixels;
        int value;

        private int pixelIndex;

        public XBMByte()
        {
            pixels = new Pixel[8];
            value = 0;
            pixelIndex = 0;
        }

        public void AddPixel(Pixel pixel)
        {
            pixels[pixelIndex++] = pixel;
        }

        private void CalculateValue()
        {
            foreach (Pixel pixel in pixels)
            {
                /* Each byte represents 8 pixels
                 * each bit is pixel on/off value */
                if (pixel.IsSet())
                {
                    this.value |= (1 << pixel.GetShiftValue());
                }
            }
        }

        /* Get number value */
        public int GetValue()
        {
            CalculateValue();
            return value;
        }

        public void Reset()
        {
            value = 0;
        }

        /* Calculates value and returns string in 0x00 format */
        public override string ToString()
        {
            CalculateValue();
            return "0x" + value.ToString("X2");
        }
    }

    class Pixel
    {
        int index, shift;
        bool set;

        private int x;

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        private int y;

        public int Y
        {
            get { return y; }
            set { y = value; }
        }


        public Pixel(int x, int y, int index, int shift, bool set)
        {
            this.x = x;
            this.y = y;
            this.shift = shift;
            this.index = index;
            this.set = set;
        }

        public bool IsSet()
        {
            return set;
        }

        public void SetState(bool state)
        {
            this.set = state;
        }

        internal int GetShiftValue()
        {
            return shift;
        }

        public override string ToString()
        {
            return "Pixel " + index + " | X:" + x + " Y:" + y + (set ? " | SET" : " | NOT");
        }
    }
}
