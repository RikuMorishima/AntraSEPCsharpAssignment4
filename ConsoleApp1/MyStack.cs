using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics1
{
    public class MyStack<T>
    {
        private class MyNode<T>
        {
            public T Entity { get; set; }
            public MyNode<T>? Next { get; set; } = null;
            public MyNode<T>? Prev { get; set; } = null;
            public MyNode(T entity)
            {
                this.Entity = entity;
            }

        }

        private int count;
        MyNode<T>? bottom;
        MyNode<T>? top;

        public MyStack()
        {
            count = 0;
            bottom = null;
            top = null;
        }

        public int Count()
        {
            return count;
        }

        public void Push(T entity)
        {
            if (bottom == null && top == null)
            {
                bottom = new MyNode<T>(entity);
                top = bottom;
                ++count;
                return;
            }
            MyNode<T> node = new MyNode<T>(entity);
            top.Next = node;
            node.Prev = top;
            top = node;

            ++count;
            return;
        }

        public T Pop()
        {
            T output;
            if (bottom == null)
                throw new Exception();
            if (bottom == top)
            {
                output = bottom.Entity;
                bottom = null;
                top = null;
                --count;
                return output;
            }
            MyNode<T> node = top.Prev;
            output = top.Entity;
            top = node;
            --count;
            return output;
        }
    }
    
}
