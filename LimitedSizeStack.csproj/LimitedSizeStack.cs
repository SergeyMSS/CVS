using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TodoApplication
{
    public class LimitedSizeStack<T>
    {
        LinkedList<T> list = new LinkedList<T>();
        int limit;
        T head;
        T prev;
        LinkedListNode<T> next;
        public LimitedSizeStack(int limit)
        {
            //LinkedList<int> lLst = new LinkedList<int>();
            //lLst.AddLast(limit);
            this.limit = limit;
        }

        public void Push(T item)
        {
            if (list.Count == 0)
            {
                head = item;
                next = null;
            }
            if (list.Count < limit)
            {
                var temp = list.Last();
                list.AddLast(item);
                prev = temp;
            }
            else
            {
                list.RemoveFirst();
                list.AddLast(item);
            }
        }

        public T Pop()
        {
            LinkedListNode<int> nodeNext = new LinkedListNode<int>(0);
            var q = list.Last();            
            list.RemoveLast();
            return q;
        }

        public int Count
        {
            get
            {
                return list.Count();
            }
        }
    }
}
