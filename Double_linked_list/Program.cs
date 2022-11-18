using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double_linked_list
{
    class Node
    {
        /*Node class represent the node of doubl Linked list
         * it consists of the informaiton part and links to
         * its succeding and preceding
         * in termes of next and perviuos
         * */

        public int noMhs;
        public string name;
        //point to the succeding node
        public Node next;
        //points to yhe preceeding node
        public Node prev;
    }


    class DoubleLinkedList
    {
        Node start;

        //constructor
        public void addNode()
        {
            int nim;
            string nm;
            Console.WriteLine("\n Enter the roll number of the students :");
            nim = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Enter students name");
            nm = Console.ReadLine(); 
            Node newNode = new Node();
            newNode.noMhs = nim;
            newNode.name = nm;

            // check if the list is empty 
            if(start == null || nim <= start.noMhs)
            {
                if ((start != null) && (nim == start.noMhs))
                {
                    Console.WriteLine("\n Duplicaite number not allwoed");
                    return;
                }
                newNode.next = start;
                if (start != null)
                    start.prev = newNode;
                newNode.next = null;
                start = newNode;
                return;
            }
            /* if the node is to be inserted between two node*/
            Node previous, current;
            for(current = previous = start;
                current != null && nim>= current.noMhs;
                previous = current, current = current.next)
            {
                if (nim == current.noMhs)
                {
                    Console.WriteLine("\n Duplicate roll number not allowes");
                    return;
                }
            }
            /* On the execution of the above for loop,prev and 
             * cureent will point to those nodes
             * between which the new node is to be inserted
             * */
            newNode.next = current;
            newNode.prev = previous;

            //if the node is to be inserted at the end of the list

            if (current == null)
            {
                newNode.next = null;
                previous.next = newNode;
                return ;
            }
            current.prev = newNode;
            previous.next = newNode;
        }

        public bool Search(int rollno, ref Node previous, ref Node current)
        {
            previous = current = start;
            while(current != null && rollno != current.noMhs)
            {
                previous = current;
                current = current.next;
            }
            return (current!= null);
        }
        public bool delNode(int rollNo)
        {
            Node previous,current;
            previous = current = null;
            if (Search(rollNo, ref previous, ref current) == false)
                return false;
            // the begining of data
            if (current.next == null)
            {
                previous.next = null;
                return true;
            }
            //Node between  two nodes in the list
            if (current == start)
            {
                start = start.next;
                if (start != null)
                    start.prev = null;
                return true;
            }
            //if the node to be deleted is between two nodes in list this lines will be executed
            previous.next = current.next;
            current.next.prev = previous;
            return true;
        }
        public void ascending()
        {
            if (ListEmpty())
                Console.WriteLine("\n List is empty");
            else
            {
                Console.WriteLine("\n Record in the ascending order of " + "Roll number are: \n");
                Node currentNode;
                for (currentNode = start; currentNode != null; currentNode = currentNode.next)
                    Console.Write(currentNode.noMhs + "  " + currentNode.name + "\n");
            }
        }

        public void descending()
        {
            if (ListEmpty())
                Console.WriteLine("\n List is empty");
            else
            {
                Console.WriteLine("\n Record in descending order of " + "Roll number are: \n");
                Node currentNode;
                // Moves currentNode to last 
                currentNode = start;
                while(currentNode.next != null)
                {
                    currentNode = currentNode.next;
                
                }
                //reads data from last to first node
                while(currentNode != null)
                {
                    Console.Write(currentNode.noMhs + "  " + currentNode.name + "\n");
                    currentNode = currentNode.prev;
                }


            }
        }

        public bool ListEmpty()
        {
            if (start == null)
                return true;
            else
                return false;
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
