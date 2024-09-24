﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearDataStructures.Logic
{
    internal class Element<T>
    {
        public Element(T data, Element<T> next)
        {
            Data = data;
            Next = next;
        }

        public T Data { get; set; }

        public Element<T> Next { get; set; }

    }
}
