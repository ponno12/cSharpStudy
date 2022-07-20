using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Fundamentals
{
    class MyList<T>
    {
        class MyNode
        {
            public MyNode _next { get; set; }
            public MyNode _head { get; set; }

            public T _data;

            public MyNode(T a)
            {
                _head = null;
                _data = a;
            }


        }

    }
}
