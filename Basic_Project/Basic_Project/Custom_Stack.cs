using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Project
{
    class Custom_Stack<T> where T:struct //only structure Type(int,double) can be present in place of T
    {
        T[] container;
        int Size;
        int Position;
        public Custom_Stack(int Size)
        {
            this.Size = Size;
            Position = -1;
            container = new T[Size];
        }
        public void Push(T obj)
        {
            if (Position < Size - 1)
                container[++Position] = obj;
            else
                Console.WriteLine("Stack Full");

        }
        public T Pop()
        {
            if (Position != -1)
                return container[Position--];
            else
            {
                Console.WriteLine("Stack Empty");
                return default(T);//This is used because we dont know the Type of T
            }
        }

    }
    class UseStack
    {
        static void Main(string[] args)
        {
            Custom_Stack<int> stack = new Custom_Stack<int>(3);
            stack.Push(100);
            stack.Push(200);
            stack.Push(300);
            int temp;
            for (int i = 0; i < 3; i++)
            {
                temp=stack.Pop();
                Console.WriteLine(temp);
            }

        }
    }
}
