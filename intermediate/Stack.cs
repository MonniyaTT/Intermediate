using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intermediate
{
    class Stack
    {
        public void InsertStack()
        {
            var stack = new Stacks();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

        }

        public class Stacks
        {
            public List<object> listStack = new List<object>();

            public void Push(object obj)
            {
                if (obj == null) Console.WriteLine("Please enter a value !!");
                listStack.Add(obj);
            }

            public object Pop()
            {
                var countList = listStack.Count();
                if (countList == 0) return ("No data in Stack !!"); 
                var pop = listStack[countList-1];
                listStack.RemoveAt(countList-1);
                return pop;
            }

            public void Clear()
            {
                listStack.Clear();
            }

        }

        

       
    }
}
