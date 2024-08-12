using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GameScript
{
    public class LinkedListSort
    {
        public Node SortedMerge(Node a, Node b)
        {
            Node result = null;
            if (a == null)
                return b;
            if (b == null)
                return a;

            if (a.StoryNumber <= b.StoryNumber)
            {
                result = a;
                result.Next = SortedMerge(a.Next, b);
            }
            else
            {
                result = b;
                result.Next = SortedMerge(a, b.Next);
            }
            return result;
        }

        public Node MergeSort(Node head)
        {
            if (head == null || head.Next == null)
                return head;

            Node middle = GetMiddle(head);
            Node nextOfMiddle = middle.Next;
            middle.Next = null;

            Node left = MergeSort(head);
            Node right = MergeSort(nextOfMiddle);

            Node sortedList = SortedMerge(left, right);

            return sortedList;
        }

        public Node GetMiddle(Node head)
        {
            if (head == null)
                return head;

            Node slow = head, fast = head.Next;
            while (fast != null)
            {
                fast = fast.Next;
                if (fast != null)
                {
                    slow = slow.Next;
                    fast = fast.Next;
                }
            }
            return slow;
        }
    }
}
