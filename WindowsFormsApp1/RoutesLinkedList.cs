using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Linked list of routes
    /// </summary>
    public sealed class RoutesLinkedList
    {
        /// <summary>
        /// Node of the linked list
        /// </summary>
        private sealed class Node
        {
            public Route Data { get; set; }     // Data of the node
            public Node Next { get; set; }      // Next node of the selected
            public Node() { }                   // Constructor without variables

            // Constructor with variables
            public Node(Route data, Node address) 
            {
                this.Data = data;
                this.Next = address;
            }
        }

        // Head, tail and the pointer of the list
        private Node head;
        private Node tail;
        private Node iP;

        // Constructor
        public RoutesLinkedList()
        {
            this.head = null;
            this.tail = null;
            this.iP = null;
        }

        public Route First() { return head.Data; }      // Returns the data of the first element
        public Route Last() { return tail.Data; }       // Returns the data of the second element

        /// <summary>
        /// Returns the number of elements in list
        /// </summary>
        public int Count
        {
            get
            {
                if (head == null)
                    return 0;
                int k = 0;
                for (Node nd = head; nd != null; nd = nd.Next)
                    k++;
                return k;
            }
        }

        /// <summary>
        /// Adds route to the front of the linked list
        /// </summary>
        /// <param name="r">Route</param>
        public void AddToFront(Route r)
        {
            var p = new Node(r, null);
            p.Next = head;
            head = new Node(r, p);
        }

        /// <summary>
        /// Adds route to the end of the linked list
        /// </summary>
        /// <param name="r">Route</param>
        public void AddToEnd(Route r)
        {
            var p = new Node(r, null);
            if(head != null)
            {
                tail.Next = p;
                tail = p;
            }
            else 
            {
                head = p;
                tail = p;
            }
        }

        /// <summary>
        /// Destroys the linked list
        /// </summary>
        public void Destroy()
        {
            while(head != null)
            {
                iP = head;
                head = head.Next;
                iP.Next = null;
            }
            tail = iP = null;
        }

        public void Start() { iP = head; }              // Pointer is pointed to the head
        public void Next() { iP = iP.Next; }            // Pointer is pointed to its next element
        public bool Exists() { return iP != null; }     // Checks if the pointer null or not 

        /// <summary>
        /// Checks if linked list contains the route
        /// </summary>
        /// <param name="myR"></param>
        /// <returns></returns>
        public bool Contains(Route myR)
        {
            for(Node p = head; p != null; p = p.Next)
            {
                Route r = p.Data;
                if (r.Equals(myR))
                    return true;
            }
            return false;
        }

        public Route GetData() { return iP.Data; }      // Gets data of the pointer

        /// <summary>
        /// Sorts the elements of the linked list
        /// </summary>
        public void Sort()
        {
            for (Node s1 = head; s1 != null; s1 = s1.Next)
            {
                Node maxv = s1;
                for (Node s2 = s1; s2 != null; s2 = s2.Next)
                    if (s2.Data >= maxv.Data)
                        maxv = s2;
                Route s = s1.Data;
                s1.Data = maxv.Data;
                maxv.Data = s;
            }
        }

        /// <summary>
        /// Removes the selected route
        /// </summary>
        /// <param name="r">Route</param>
        public void Remove(Route r)
        {
            if(r == head.Data)
            {
                Node p = head;
                head = head.Next;
                p.Next = null;
            }
            else
            {
                for(Node mm = head; mm != null; mm = mm.Next)
                {
                    if(mm.Next.Data == r)
                    {
                        Node p = mm;
                        p.Next = mm.Next;
                        mm.Next.Next = null;
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Removes all routes with the entered symbol
        /// </summary>
        /// <param name="symbol">Symbol to check</param>
        public void RemoveALL(char symbol)
        {
            for (Node s1 = head; s1 != null; s1 = s1.Next)
            {
                if (s1.Data.name.Contains(char.ToLower(symbol)) || s1.Data.name.Contains(char.ToUpper(symbol)))
                {
                    Node temp = head, previous = null;
                    if (temp != null && ((temp.Data.name.Contains(char.ToLower(symbol)) || temp.Data.name.Contains(char.ToUpper(symbol)))))
                    {
                        head = temp.Next; 
                        return;
                    }
                    while (temp != null && ((!temp.Data.name.Contains(char.ToLower(symbol)) && !temp.Data.name.Contains(char.ToUpper(symbol)))))
                    {
                        previous = temp;
                        temp = temp.Next;
                    }
                    if (temp == null) return;
                    previous.Next = temp.Next;
                }
            }
        }

        /// <summary>
        /// Inserts data from the entered linked list
        /// </summary>
        /// <param name="Insertion">List to be inserted</param>
        public void InsertAll(RoutesLinkedList Insertion)
        {
            for (Insertion.Start(); Insertion.Exists(); Insertion.Next())
            {
                Route r = Insertion.GetData();
                if (!this.Contains(r))
                {
                    Node n = new Node();
                    n.Data = r;
                    n.Next = null;
                    if (head == null) head = n;
                    else
                    {
                        if (head.Data < r)
                        {
                            n.Next = head;
                            head = n;
                        }
                        else
                        {
                            Node s = head;
                            while (s != null && s.Next != null && r <= s.Next.Data)
                                s = s.Next;
                            n.Next = s.Next;
                            s.Next = n;
                        }
                    }
                }
            }
        }
    }
}
