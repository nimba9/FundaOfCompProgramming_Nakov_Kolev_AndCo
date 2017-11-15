using System;
using System.Collections.Generic;


namespace Task11___DoubleLinkedList
{
    public class DoubleLinkedList<T> : IEnumerable<T>
    {
        private DoubleLinkedListNode<T> head;
        private DoubleLinkedListNode<T> tail;
        private int count;
        public DoubleLinkedList()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public DoubleLinkedList(DoubleLinkedList<T> list)
        {
            this.tail.Next = list.head;
            list.head.Previous = this.tail;
            count += list.Count;
            this.tail = list.tail;
        }

        //Add an element to the list
        public void Add(T element)
        {
            if (count == 0)
            {
                this.head = new DoubleLinkedListNode<T>(element);
                this.tail = this.head;
            }
            else
            {
                this.tail = new DoubleLinkedListNode<T>(element, this.tail);
            }
            count++;
        }

        //Remove an element if exist, if not returns false;
        public bool Remove(T element)
        {
            int index = Find(element);

            if (index == -1)
            {
                return false;
            }

            DoubleLinkedListNode<T> node = ReturnsNodeByIndex(index);
            node.RemoveEl();
            if (index == 0)
            {
                this.head = node.Next;
            }

            if (index == count - 1)
            {
                this.tail = node.Previous;
            }
            count--;
            return true;
        }


        //Returns the index of an element, returns -1 if not found
        public int Find(T element)
        {
            DoubleLinkedListNode<T> forwardNode = this.head;
            int forward = 0;
            while (forwardNode != null)
            {
                if (forwardNode.Element.Equals(element))
                {
                    return forward;
                }

                forward++;
                forwardNode = forwardNode.Next;

            }
            return -1;
        }


        private DoubleLinkedListNode<T> ReturnsNodeByIndex(int index)
        {
            if (index > count - index)
            {
                int i = count - 1;
                DoubleLinkedListNode<T> node = this.tail;

                while (true)
                {
                    if (i == index)
                    {
                        return node;
                    }
                    node = node.Previous;
                    i--;
                }
            }
            else
            {
                int i = 0;
                DoubleLinkedListNode<T> node = this.head;

                while (true)
                {
                    if (i == index)
                    {
                        return node;
                    }
                    node = node.Next;
                    i++;
                }
            }
        }


        public void Insert(T element, int index)
        {
            if (index < 0 || index > count)
            {
                throw new ArgumentOutOfRangeException("The index is out of bounds");
            }

            if (index == 0)
            {
                DoubleLinkedListNode<T> node = new DoubleLinkedListNode<T>(element);
                node.Next = this.head;
                this.head = node;
                count++;
            }
            else if (index == count)
            {
                this.tail = new DoubleLinkedListNode<T>(element, this.tail);
                count++;
            }
            else
            {
                DoubleLinkedListNode<T> node = ReturnsNodeByIndex(index - 1);
                DoubleLinkedListNode<T> newNode = new DoubleLinkedListNode<T>(element);
                newNode.Next = node.Next;
                newNode.Previous = node;
                node.Next = newNode;
                count++;
            }
        }

        public T[] ToArray()
        {
            T[] elements = new T[count];
            DoubleLinkedListNode<T> h = this.head;

            for (int i = 0; i < count; i++)
            {
                elements[i] = h.Element;
                h = h.Next;
            }

            return elements;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index > count - 1)
                {
                    throw new ArgumentOutOfRangeException("Index out of bounds");
                }

                return ReturnsNodeByIndex(index).Element;
            }
        }

        public class DoubleLinkedListNode<T>
        {
            private T element;


            DoubleLinkedListNode<T> next;
            DoubleLinkedListNode<T> previous;



            public DoubleLinkedListNode()
            {
                element = default(T);
                next = null;
                previous = null;
            }

            public DoubleLinkedListNode(T element)
            {
                this.element = element;
                next = null;
                previous = null;
            }

            public DoubleLinkedListNode(T element, DoubleLinkedListNode<T> previous)
            {
                this.element = element;
                this.next = null;
                this.previous = previous;
                previous.next = this;
            }


            public void RemoveEl()
            {
                if (this.previous != null && this.next != null)
                {
                    this.previous.next = this.next;
                    this.next.previous = this.previous;
                }
                else if (this.previous != null)
                {
                    this.previous.next = null;
                }
                else
                {
                    this.next.previous = null;
                }
            }

            public T Element
            {
                get { return element; }
                set { element = value; }
            }

            public DoubleLinkedListNode<T> Next
            {
                get { return this.next; }
                set { next = value; }
            }

            public DoubleLinkedListNode<T> Previous
            {
                get { return this.previous; }

                set { previous = value; }
            }
        }

        public int Count
        {
            get { return count; }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            DoubleLinkedList<T> list = this;

            if (list != null)
            {
                DoubleLinkedListNode<T> el = list.head;
                while (el != null)
                {
                    yield return el.Element;
                    el = el.Next;
                }
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            DoubleLinkedList<int> linkedList = new DoubleLinkedList<int>();

            int n = int.Parse(Console.ReadLine());

            string[] nums = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < n; i++)
            {
                linkedList.Add(int.Parse(nums[i]));
            }

            string[] positionAndElements = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int elementToBeInserted = int.Parse(positionAndElements[1]);
            int positionToBeInserted = int.Parse(positionAndElements[0]);
            int elementToBeRemoved = int.Parse(positionAndElements[2]);
            int elementToBeFound = int.Parse(positionAndElements[3]);

            linkedList.Insert(elementToBeInserted, positionToBeInserted);
            linkedList.Remove(elementToBeRemoved);


            foreach (int num in linkedList)
            {
                Console.Write("{0} ", num);
            }
            Console.WriteLine();
            Console.WriteLine(linkedList.Find(elementToBeFound));

        }
    }
}