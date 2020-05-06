using System;

namespace Lv3_Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dataset data = new Dataset("C:\\Users\\MIHAEL\\LV3-Doop\\DoopFile.csv");
            Dataset clone = (Dataset)data.Clone();
            Dataset deep = (Dataset)data.DeepClone();
            clone.ClearData();
            double[][] task2 = RandomGenerator.GetInstance().GetMatrix(4, 4);
            double[][] task2a = RandomGenerator.GetMatrixStatic(4, 4);
        }
    }
}
