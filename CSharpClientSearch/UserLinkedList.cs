using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpClientSearch
{
    public class UserLinkedList<T> : IEnumerable<T>
    {
        Node<T> head;
        Node<T> tail;

        public int Count
        {
            get;
            private set;
        }

        public void Add(T value)
        {
            Node<T> node = new Node<T>(value);

            if (head == null)
            {
                head = node;
                tail = node;
            }

            else
            {
                tail.Next = node;
                tail = node;
            }
            Count++;
        }
        public void UserCopyTo(T[] array, int index)
        {
            for (Node<T> node = head; node != null; node = node.Next)
            {
                array[index++] = node.Value;
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            {
                for (Node<T> node = head; node != null; node = node.Next)
                {
                    yield return node.Value;
                }
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();
        }
    }
}
