using System;

namespace SLL
{
    internal class Node
    {
        public Node next;
        public Node previous;
        int data { get; set; }

        ~Node()
        {
            this.previous = this.next;
        }

        public Node(int data,Node backlink)
        {
            this.data = data;
            this.previous = backlink;
        }
        public void Append(int data)
        {
            if (this.next == null)
                this.next = new Node(data,this);
            else
                this.next.Append(data);
        }
        public void Out()
        {
            Console.Write($"{this.data} ");
            if (this.next != null)
            { this.next.Out(); }
            else { Console.WriteLine("\0"); }
        }
        //public bool Find(int data)
        //{
        //    if (this.data == data)
        //        return true;
        //    if (this.data != data)
        //    {
        //        if (this.next != null)
        //            this.next.Find(data);
        //        else return false;
        //    }
        //    else return false;
        //}
        ////public Node FindP(int data)
        ////{
        ////    if (this.data == data)
        ////        return this;
        ////    else
        ////    {
        ////        if (this.data != data)
        ////        {
        ////            if (this.next != null)
        ////                this.next.Find(data);
        ////            else return null;
        ////        }
        ////        else return null;
        ////        return null;
        ////    }
        ////}
    }
    internal class SLL
    {
        Node root;

        public void InitAppend(int data)
        {
            if (root == null)
                root = new Node(data,null);
            else
            {
                root.Append(data);
            }
        }
        public void InitOut()
        {
            root.Out();
        }
        //public bool InitFind(int data)
        //{
        //    return root.Find(data);
        //}
    }

    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}