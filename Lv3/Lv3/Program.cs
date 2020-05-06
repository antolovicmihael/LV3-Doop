using System;

namespace Lv3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dataset data = new Dataset("C:\\Users\\MIHAEL\\LV3-Doop\\DoopFile.csv");
            Dataset clone = (Dataset)data.Clone();
            Dataset deep = (Dataset)data.DeepClone();
            clone.ClearData();
        }
    }
}
