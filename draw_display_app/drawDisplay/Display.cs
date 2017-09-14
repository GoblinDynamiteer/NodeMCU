using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace drawDisplay
{
    class Display
    {
        static public int Width = 128;
        static public int Height = 64;

        private Pixel[] pixels;
        private XBMByte[] xbmArray;

        private byte[] test_bits = {
        0x13, 0x00, 0x15, 0x00, 0x93, 0xcd, 0x55, 0xa5, 0x93, 0xc5, 0x00, 0x80,
        0x00, 0x60 };

        /* XBM
        #define test_width 16
        #define test_height 7
        static char test_bits[] = {
        0x13, 0x00, 0x15, 0x00, 0x93, 0xcd, 0x55, 0xa5, 0x93, 0xc5, 0x00, 0x80,
        0x00, 0x60 };
         */

        /* Constructor */
        public Display()
        {
            pixels = new Pixel[Width * Height]; // 8192
            xbmArray = new XBMByte[Width * Height / 8]; // 1024

            InitPixels();
            InitBytes();

        }

        void InitPixels()
        {
            int i = 0;
            int shift = 0;

            for (int x = 1; x <= Width; x++)
            {
                for (int y = 1; y <= Height; y++)
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

    }

    class XBMByte
    {
        Pixel[] pixels;
        byte value;

        private int pixelIndex;

        public XBMByte()
        {
            pixels = new Pixel[8];
            value = 0x00;
            pixelIndex = 0;
        }

        public void AddPixel(Pixel pixel)
        {
            pixels[pixelIndex++] = pixel;
        }

        private void CalculateValue()
        {
            int value = 0;

            foreach (Pixel pixel in pixels)
            {
                if (pixel.IsSet())
                {
                    value |= 1 << pixel.GetShiftValue();
                }
            }

            this.value = (byte)value;
        }

        public byte GetValue()
        {
            CalculateValue();
            return value;
        }

        public override string ToString()
        {
            return "0x" + value.ToString("X2");
        }
    }

    class Pixel
    {
        int x, y, index, shift;
        bool set;

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

        internal int GetShiftValue()
        {
            return shift;
        }

        public override string ToString()
        {
            return "Pixel " + index + "X: " + x + "Y:" + y;
        }
    }
}
