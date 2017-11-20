using GSharp.Extension.Abstracts;
using GSharp.Extension.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSharp.Modules.Sort
{
    public class ArraySort : GModule
    {
        [GCommand("{0} 배열 순서대로 정렬")]
        public static void SortArray(Array arr)
        {
            Array.Sort(arr);
        }

        [GCommand("{0} 배열 역순으로 정렬")]
        public static void ReverseArray(Array arr)
        {
            Array.Sort(arr);
            Array.Reverse(arr);
        }
    }
}
