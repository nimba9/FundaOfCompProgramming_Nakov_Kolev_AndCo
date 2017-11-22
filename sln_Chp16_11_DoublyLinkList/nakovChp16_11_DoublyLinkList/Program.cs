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

class MyLinkedListNode<T>
{
    public T Value
    {
        get;
        private set;
    }

    public MyLinkedListNode<T> Next
    {
        get;
        private set;
    }

    public MyLinkedListNode<T> Previous
    {
        get;
        private set;
    }

    public MyLinkedListNode(T value)
    {
        this.Value = value;
    }


}



class MyLinkedList<T> where T: IComparable
{
    public static MyLinkedListNode<T> First
    {
        get;
        private set;
    }

    public static MyLinkedListNode<T> Last
    {
        get;
        private set;
    }

    public int Count
    {
        get;
        private set;
    }

    public MyLinkedList()
    {
        First = null;
        Last = null;
        Count = 0; 
    }

    public void AddLast(T value)
    {
        if (Last == null)
        {
            First = Last = new MyLinkedListNode<T>(value);
        }
    }


}






