using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics2
{
    public class MyList<T>
    {
        private class MyNode<T>
        {
            public T Entity { get; set; }
            public MyNode<T>? Next { get; set; } = null;
            public MyNode(T entity)
            {
                this.Entity = entity;
            }

            
        }
        private int count;
        MyNode<T>? head;

        public MyList()
        {
            count = 0;
            head = null;
        }

        public void Add(T element)
        {
            if (head == null)
            {
                head = new MyNode<T>(element); 
                count++;
                return;
            }
            MyNode<T> node = new MyNode<T>(element);
            MyNode<T> current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = node;
            count++;
            return;
        }

        public T Remove(int index)
        {
            throw new NotImplementedException();
        } 

        bool Contains(T element)
        {
            MyNode<T> current = head;
            while (head != null)
            {
                if (head.Entity.Equals(element)) return true;
                current = current.Next;
            }

            return false;
        }

        void Clear()
        {
            while (head != null)
            {
                this.DeleteAt(count - 1);
            }
        }

        void InsertAt(T element, int index)
        {
            if (head == null && index == 0)
            {
                head = new MyNode<T>(element);
                count++;
                return;
            }
            MyNode<T> node = new MyNode<T>(element);
            MyNode<T> current = head;
            int i = 0;
            while (current != null && i < index - 1)
            {
                current = current.Next;
                i++;
            }
            if (current == null)
            {
                throw new IndexOutOfRangeException();
            }
            MyNode<T> currentsNext = current.Next;
            current.Next = node;
            node.Next = currentsNext;
            count++;
        }

        void DeleteAt(int index)
        {
            MyNode<T> node = head;
            for (int i = 0; i < index - 1; ++i)
            {
                node = node.Next;
            }
            if (node.Next.Next == null)
            {
                node.Next = null;
                count--;
                return;
            }
            node.Next = node.Next.Next;
            count--;


        }

        T Find(int index)
        {
            MyNode<T> current = head;
            for (int i =0; i < index; i++)
            {
                current = current.Next;
            }
            return current.Entity;
        }

    }
}
