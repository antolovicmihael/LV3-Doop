using System;
using System.Collections.Generic;
using System.Text;

namespace Lv3
{
    interface Prototype
    {
        Prototype Clone();
        Prototype DeepClone();
    }
}