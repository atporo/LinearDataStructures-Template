using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable

namespace DemoGenerics
{
    internal class Point<T> // Klasse vom Typ point generisch
    {
        public T x {  get; set; }

        public T y { get; set; }
    }
}
