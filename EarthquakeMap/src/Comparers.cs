﻿using System;
using System.Collections.Generic;
using EarthquakeLibrary;

namespace EarthquakeMap
{
    class IntensityComparer : IComparer<string>
    {
        private static readonly string[] IntList = { "1", "2", "3", "4", "震度５弱以上未入電", "5弱", "5強", "6弱", "6強", "7" };
        public int Compare(string x, string y) => Array.IndexOf(IntList, x) - Array.IndexOf(IntList, y);
    }

    class IntensityEqualComparer : IEqualityComparer<(string, Intensity, float)>
    {
        public bool Equals((string, Intensity, float) x, (string, Intensity, float) y) {
            return x.Item1.Equals(y.Item1);
        }

        public int GetHashCode((string, Intensity, float) obj) {
            return obj.Item1.GetHashCode();
        }
    }
}
