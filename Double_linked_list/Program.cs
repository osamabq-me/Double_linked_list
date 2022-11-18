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
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
