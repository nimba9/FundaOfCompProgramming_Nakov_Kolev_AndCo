using System;
using System.Collections;
using System.Collections.Generic;

//nakov& Co C# book/Chp16 ex11: 
//Implement the data structure dynamic doubly linked list
//(DoublyLinkedList<T>) – list, the elements of which have pointers both
//to the next and the previous elements. Implement the operations for
//adding, removing and searching for an element, as well as inserting an
//element at a given index, retrieving an element by a given index and a
//method, which returns an array with the elements of the list.

class ListElm<T>
{
    public T Value
    { get; private set; }

    public ListElm<T> NxtElm
    { get; internal set; }

    public ListElm<T> PrvElm
    { get; internal set; }

    public ListElm(T value)
    { this.Value = value; }

}


class DoubLinkList<T> where T : IComparable
{
    public static ListElm<T> Head
    { get; private set; }

    public static ListElm<T> Tail
    { get; private set; }

    public int Count
    { get; private set; }

    public DoubLinkList()
    {
        Head = null;
        Tail = null;
        Count = 0;

    }



    public void AddFirst(T value)
    {
        if (Head == null)
        {
            Tail = new ListElm<T>(value);
            Head = Tail;
        }

        else
        {
            Head.PrvElm = new ListElm<T>(value);
            Head.PrvElm.NxtElm = Head;
            Head = Head.PrvElm;
        }


        Count++;
        
    }

    public void  AddLast(T value)
    {
        if (Tail == null)
        {
            Head = new ListElm<T>(value);
            Tail = Head;
        }

        else
        {
            Tail.NxtElm = new ListElm<T>(value);
            Tail.NxtElm.PrvElm = Tail;
            Tail = Tail.NxtElm;
        }

        Count++;
    }

    public void Remove(T value)
    {
        ListElm<T> currElm = Head;

        while (currElm != null)
        {
            if (currElm.Value.CompareTo(value) == 0)
            {
                if (currElm.PrvElm != null)
                { currElm.PrvElm.NxtElm = currElm.NxtElm; }

                else
                { Head = currElm.NxtElm; }

                if (currElm.NxtElm != null)
                { currElm.NxtElm.PrvElm = currElm.PrvElm; }

                currElm = null;
                Count--;
                break;
            }

            currElm = currElm.NxtElm;
        }
        
    }

    public void Clear()
    {
        Head = null;
        Tail = null;
        Count = 0;
        Console.WriteLine("The list content has been cleared");
    }

    public T[] ToArray()
    {
        T[] arr = new T[Count];
        ListElm<T> current = Head;

        for (int i = 0; i < Count; i++)
        {
            arr[i] = current.Value;
            current = current.NxtElm;
        }

        return arr;
    }
}

class TestProgram
{

    public static void Main(string[] args)
    {
        DoubLinkList<int> dLinkList = new DoubLinkList<int>();

        Console.WriteLine("Count:" + dLinkList.Count);

        //for (int i = 0; i < 5; i++)
        //{
        //    dLinkList.AddFirst(i);
        //}

        //Console.WriteLine("Adding first");
        //Print(dLinkList);

        //dLinkList.Clear();

        for (int i = 0; i < 5; i++)
        {
            dLinkList.AddLast(i);
        }

        Console.WriteLine("Adding last");
        Print(dLinkList);

        //dLinkList.Clear();

        Console.WriteLine("Existing element will be removed:number 1");
        dLinkList.Remove(1);
        Print(dLinkList);




    }

    static void Print(DoubLinkList<int> list)
    {
        int[] storedList = list.ToArray();

        foreach (var item in storedList)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();
    }


}


