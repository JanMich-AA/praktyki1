using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie10
{
    internal class MySubClass : MyBaseClass
    {
        public MySubClass(string baseClassNeedsThis, int anotherValue) : base(baseClassNeedsThis)
        {
            MessageBox.Show("To jest klasa pochodna: " + baseClassNeedsThis + " i " + anotherValue);
        }
    }
}
