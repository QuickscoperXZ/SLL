using System;
using System.Threading;

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
        public void Add100()
        {
            Random newValue = new Random();
            for (int i = 0;i<=100;i++)
            { this.Append(newValue.Next(-1000, 1000)); }
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
        public void Even()
        {
            if (this.next != null)
            {
                if (data % 2 == 0)
                { Console.WriteLine($"Число {data} - чётное"); }
                next.Even();
            }
        }
        public void Uneven()
        {
            if (this.next != null)
            {
                if (data % 2 != 0)
                { Console.WriteLine($"Число {data} - нечётное"); }
                next.Uneven();
            }
        }
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
        public void InitEven()
        {
            root.Even();
        }
        public void InitUneven()
        {
            root.Uneven();
        }
        public void Init100()
        {
            if (root == null)
            { root = new Node(new Random().Next(-1000,1000),null); }
            root.Add100();
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
            SLL sll = new SLL();
            sll.Init100();
            //sll.InitOut();
            //Console.ReadKey();
            //Console.Clear();
            //sll.InitEven();
            //Console.ReadKey();
            //Console.Clear();
            //sll.InitUneven();
            //Console.ReadKey();
            Thread ThreadEven = new Thread(sll.InitEven);
            Thread ThreadUneven = new Thread(sll.InitUneven);

            ThreadEven.Start();
            ThreadUneven.Start();

            Console.ReadKey();

        }
    }
}