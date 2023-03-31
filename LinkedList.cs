using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListLab
{
    internal class LinkedList
    {
        public Node Head {get;set;}

        public ulong Count { get;set;}

        public LinkedList ()
        {
            Head = null;
        }

        public void AddFirst (string value)
        {
            // Create new node
            Node newNode = new Node ();

            // Set value of new nod
            newNode.Value = value;

            // Get the node at the head
            Node head = this.Head;

            // Set the next of new node to node at head
            newNode.Next = head;

            // Set the head to the new node
            this.Head = newNode;

            // Icrement Count
            this.Count++;
        }

        public void AddLast (string value)
        {
            // Create new node with value
            Node newNode = new Node();

            newNode.Value = value;

            newNode.Next = null;

            // Loop until the last node
            // Assign new node to next of the last node
            Node head = this.Head;

            if (head == null) 
            {
                this.Head = newNode;
                this.Count++;
            }
            else
            {
                Node tempNode = new Node ();

                tempNode = head;

                while (tempNode.Next != null)
                {
                    tempNode = tempNode.Next;
                }

                tempNode.Next = newNode;

                
                this.Count++;
            }

            
        }


        public void RemoveFirst()
        {
            Node head = this.Head;
            Node firstNode = head.Next;
            //Node secondNode = firstNode.Next;
            this.Head.Next = firstNode;
            this.Count--;
        }


        public void RemoveLast()
        {
            Node head = this.Head;
            if (head == null)
            {
                throw new CanNotRemoveException();
            }
            else
            {
                Node tempNode = head.Next;
                while (tempNode.Next != null)
                {
                    Node previousNode = tempNode;
                    tempNode = tempNode.Next;
                }
                tempNode.Next = null;
            }
        }

        public string RetrivingValuleAtIndex(int index)
        {
            int trackingIndex = 1;

            Node head = this.Head;

            if (head == null)
            {
                throw new NullReferenceException ();
            }
            else
            {
                if (index == 1)
                {
                    return head.Value;
                }
                else
                {
                    Node tempNode = head.Next;
                    trackingIndex = 2;
                    while (trackingIndex < index)
                    {
                        tempNode = tempNode.Next;
                        trackingIndex++;
                    }
                    string result = tempNode.Value;
                    return result;
                }
                
            }
        }
    }
}
