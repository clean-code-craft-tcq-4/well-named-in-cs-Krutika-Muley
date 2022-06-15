using System;
using System.Collections.Generic;
using System.Text;

namespace TelCo.ColorCoder
{      
      public static class ColorToPairInfo 
    {      
        public static int GetPairNumberFromColor(ColorPair pair)
        {
            // Find the major color in the array and get the index
            int majorIndex = -1;
            for (int i = 0; i < Colors.colorMapMajor.Length; i++)
            {
                if (Colors.colorMapMajor[i] == pair.majorColor)
                {
                    majorIndex = i;
                    break;
                }
            }

            int minorIndex = -1;
            for (int i = 0; i < Colors.colorMapMinor.Length; i++)
            {
                if (Colors.colorMapMinor[i] == pair.minorColor)
                {
                    minorIndex = i;
                    break;
                }
            }

            if (majorIndex == -1 || minorIndex == -1)
            {
                throw new ArgumentException(
                    string.Format("Unknown Colors: {0}", pair.ToString()));
            }

            // Compute pair number and Return  
            // (Note: +1 in compute is because pair number is 1 based, not zero)
            return (majorIndex * Colors.colorMapMinor.Length) + (minorIndex + 1);
        }
      }
    }
