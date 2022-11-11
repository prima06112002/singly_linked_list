﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace singly_linked_list
{
    // each node consist of the information part and lik to to the next mode

    class Node
    {
        public int rollNumber;
        public string name;
        public Node next;
    }
    class List
    {
        Node START;

        public List()
        {
            START = null;
        }
        
        public void addNote() // add a node in the list
        {
            int nim;
            string nm;
            Console.WriteLine("\nEnter the roll number of the student : ");
            nim = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the name of student : ");
            nm = Console.ReadLine();
            Node newnode = new Node();
            newnode.name = nm;
            //if the node to be inserted in the first node
            if (START == null || nim <= START.rollNumber)
            {
                if ((START != null) && (nim == START.rollNumber))
                {
                    Console.WriteLine("\nDuplicate roll numbers not allowes\n");
                        return;
                }
                newnode.next = START;
                START = newnode;
                return;
            }

            // locate the position of the new node in the list
            Node previous, current;
            previous = START;
            current = START;

            while ((current != null) && (nim >= current.rollNumber))
            {
                if (nim == current.rollNumber)
                {
                    Console.WriteLine("\nDuplicate roll numbers not allowed\n");
                    return ;
                }
                previous = current;
                current = current.next;
            }

            //*once the above for loop is executed, prev and current are positioned in such a manner that the position for the new node */
            newnode.next = current;
            previous.next = newnode;
        }
        public void traverse()
        {
            if (listEmpty())
                Console.WriteLine("\nlist is empt.\n");
            else
            {
                Console.WriteLine("\nThe records in the list are : ");
                Node currentNode;
                for (currentNode = START; currentNode != null;
                    currentNode = currentNode.next)

                    Console.Write(currentNode.rollNumber + " " + currentNode.name + "\n");

                Console.WriteLine();
            }   
        }
        public bool delNode(int nim)
        {
            Node previous, current;
            previous = current = null;
            // check if the spesified node is present in the list or not
            if (Search(nim, ref previous, ref current) == false)
                return false;
            previous.next = current.next;
            if (current == START)
                START = START.next;
            return true; 
        }
        public bool Search(int nim, ref Node previous, ref Node current)
        {
            previous = START;
            current = START;

            while ((current != null) && (nim >= current.rollNumber))
            {
                previous = current;
                current = current.next;
            }
            if (current == null)
                return (false);
            else
                return (true);
        }

        public bool listEmpty()
        {
            if (START == null)
                return true;
            else
                return false;


        }

    }
}
