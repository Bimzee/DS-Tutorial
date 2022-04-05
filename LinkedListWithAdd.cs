using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class LinkedListNode<T>
    {
        public LinkedListNode(T value)
        {
            Value = value;
        }

        public T Value { get; internal set; }
        public LinkedListNode<T> Next { get; internal set; }
    }
    public class LinkedListWithAdd<T>
    {
        private LinkedListNode<T> _head;
        private LinkedListNode<T> _tail;

        public int Count { get; private set; }

        public LinkedListWithAdd()
        {

        }
        public void Add(T value)
        {
            var node = new LinkedListNode<T>(value);
            if(_head==null)
            {
                _head = node;
                _tail = node;
            }
            else
            {
                _tail.Next = node;
                _tail = node;
            }
            Count++;
        }

        public void Remove(T item)
        {
            LinkedListNode<T> previous = null;
            LinkedListNode<T> current = _head;

            while(current!=null)
            {
                if(current.Value.Equals(item))
                {
                    if(previous !=null)
                    {
                        previous.Next = current.Next;

                        // if node is the last one
                        if(current.Next == null)
                        {
                            _tail = previous;
                        }
                        Count--;
                    }
                }
                previous = current; 
                current = current.Next;
            }
        }

        public void Print()
        {
            while (_head != null)
            {
                Console.WriteLine($"Value ={_head.Value}");
                _head = _head.Next;
            }
        }
    }
}
