using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Project
{
    class Custom_Queue<T>
    {
        T[] container;
        int Size;
        int PositionStart,PositionEnd;
        public Custom_Queue(int Size)
        {
            this.Size = Size;
            PositionStart = 0;
            PositionEnd = -1;
            container = new T[Size];
        }
        public void Enqueue(T obj)
        {
            if ((PositionEnd - PositionStart+1) != Size)
                container[++PositionEnd] = obj;
            else
                Console.WriteLine("Queue Full");
            
            //Console.WriteLine(PositionStart);
            //Console.WriteLine(PositionEnd);

        }
        public T Dequeue()
        {
           
                if (PositionStart <= PositionEnd)
                    return container[PositionStart++];
            else
            {
                Console.WriteLine("Queue Empty");
                return default(T);//This is used because we dont know the Type of T
            }
        }

    }
    class UseQueue
    {
        static void Main(string[] args)
        {
            Custom_Queue<int> queue= new Custom_Queue<int>(3);
            queue.Enqueue(100);
            queue.Enqueue(200);
            queue.Enqueue(300);
            int temp;
            for (int i = 0; i < 5; i++)
            {
                temp = queue.Dequeue();
                Console.WriteLine(temp);
            }

        }
    }
}
