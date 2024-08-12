using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScript
{
    public class Node
    {
        public int StoryNumber { get; set; }
        public string StoryText { get; set; }
        public Node Next { get; set; }

        public Node(int storyNumber, string storyText)
        {
            StoryNumber = storyNumber;
            StoryText = storyText;
            Next = null;
        }
    }
}