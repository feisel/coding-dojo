using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cellent.CodingDojo.StackKata
{
    interface IStack<TElement>
    {
        void Push(TElement element);
        TElement Pop();
    }
}
