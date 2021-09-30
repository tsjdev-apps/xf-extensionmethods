using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace XFExtensionMethods.Common
{
    public static class ObjectExtensions
    {
        public static string AsString(this object input)
        {
            return input == null ? string.Empty : input.ToString();
        }

        public static void WriteLine(this object input)
        {
            Debug.WriteLine(input.AsString());
        }
    }
}
