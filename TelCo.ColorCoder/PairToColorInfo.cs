using System;
using System.Collections.Generic;
using System.Text;

namespace TelCo.ColorCoder
{
    public static class PaitToColorInfo 
    {
        public static ColorPair GetColorFromPairNumber(int pairNumber)
        {
            // The function supports only 1 based index. Pair numbers valid are from 1 to 25
            int minorSize = Colors.colorMapMajor.Length;
            int majorSize = Colors.colorMapMinor.Length;
            if (pairNumber < 1 || pairNumber > minorSize * majorSize)
            {
                throw new ArgumentOutOfRangeException(
                    string.Format("Argument PairNumber:{0} is outside the allowed range", pairNumber));
            }

            // Find index of major and minor color from pair number
            int zeroBasedPairNumber = pairNumber - 1;
            int majorIndex = zeroBasedPairNumber / minorSize;
            int minorIndex = zeroBasedPairNumber % minorSize;

            // Construct the return val from the arrays
            ColorPair pair = new ColorPair()
            {
                majorColor = Colors.colorMapMajor[majorIndex],
                minorColor = Colors.colorMapMinor[minorIndex]
            };

            // return the value
            return pair;
        }
       }
      }
