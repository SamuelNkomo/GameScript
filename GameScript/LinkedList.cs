using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScript
{
    public class LinkedList
    {
        public Node Head { get; set; }

        public void AddNode(int storyNumber, string storyText)
        {
            Node newNode = new Node(storyNumber, storyText);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public void PrintList()
        {
            Node current = Head;
            while (current != null)
            {
                System.Console.WriteLine($"{current.StoryNumber}: {current.StoryText}");
                current = current.Next;
            }
        }
    }
}