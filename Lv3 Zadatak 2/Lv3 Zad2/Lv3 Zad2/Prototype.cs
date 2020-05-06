using System;
using System.Collections.Generic;
using System.Text;

namespace Lv3_Zad2
{
    interface Prototype
    {
        Prototype Clone();
        Prototype DeepClone();
    }
}