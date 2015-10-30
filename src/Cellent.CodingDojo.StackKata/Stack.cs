using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cellent.CodingDojo.StackKata
{
    public class Stack<TElement> : IStack<TElement>
    {
        List<TElement> elements = new List<TElement>();

        public TElement Pop()
        {
            if (elements.Count == 0)
                throw new InvalidOperationException();

            var element = elements.Last();
            elements.RemoveAt(elements.Count - 1);
            return element;
        }

        public void Push(TElement element)
        {
            elements.Add(element);
        }
    }
}
