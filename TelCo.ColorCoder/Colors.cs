using System.Drawing;

namespace TelCo.ColorCoder
{
    class Colors
    {

        static Colors()
        {
            colorMapMajor = new Color[] { Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet };
            colorMapMinor = new Color[] { Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray };
        }
        /// <summary>
        /// Array of Major colors
        /// </summary>
        private static Color[] colorMapMajor;
        /// <summary>
        /// Array of minor colors
        /// </summary>
        private static Color[] colorMapMinor;
        /// <summary>
        /// data type defined to hold the two colors of clor pair
        /// </summary>
    }
}
