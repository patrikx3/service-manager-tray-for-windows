using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace chc.servicemanagertray
{
    public static class ColorHelper
    {
        public static Color ChangeBrightness(this Color instance, int brightness_modifier)
        {
            return Color.FromArgb(
                Math.Min(
                    Math.Max(instance.R + brightness_modifier, 0),
                    255
                ),
                Math.Min(
                    Math.Max(instance.G + brightness_modifier, 0),
                    255
                ),
                Math.Min(
                    Math.Max(instance.B + brightness_modifier, 0),
                    255
                )
            );        
        }
    }
}
