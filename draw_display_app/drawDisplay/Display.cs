using System.Collections.Generic;
using System.Windows.Forms;

namespace drawDisplay
{
    class Display
    {
        static public int Width = 128;
        static public int Height = 64;

        bool[,] pixels;

        /* Constructor */
        public Display()
        {
            pixels = new bool[Width, Height];
            Clear();
        }

        public void SetPixel(bool state, int x, int y)
        {
            try
            {
                pixels[x, y] = state;
            }

            catch (System.Exception)
            {

            }
            
        }

        public void Clear()
        {
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    pixels[x, y] = false;
                }
            }
        }
    }
}
