﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScript
{
    public class ScriptManager
    {
        public void PopulateLinkedList(LinkedList list)
        {
            List<Tuple<int, string>> storyData = new List<Tuple<int, string>>()
            {
                Tuple.Create(3, "With every line of code mastered, Alex gains experience points, levelling up and unlocking new abilities like Debugging Dash and Algorithmic Aura."),
                Tuple.Create(12, "The tale of Alex, the IT student-turned-digital-legend, is forever etched in the annals of Cybersphere, inspiring aspiring programmers to pursue their dreams."),
                Tuple.Create(4, "The Firewall Fortress looms ahead, its defences formidable, but Alex's mastery of cybersecurity allows them to breach the walls with a series of perfectly timed hacks."),
                Tuple.Create(2, "Armed with a trusty keyboard and a digital sword, Alex enters the Coding Caverns, where bugs and glitches guard the treasures of programming wisdom."),
                Tuple.Create(1, "In the virtual realm of Cybersphere, our hero, Alex, a determined IT student, embarks on an epic quest for knowledge."),
                Tuple.Create(7, "Along the journey, Alex forges alliances with NPC coders, forming a guild known as \"Syntax Sentinels,\" united by their dedication to digital mastery."),
                Tuple.Create(10, "Victory is hard-won, but Alex's leadership and IT prowess lead to the defeat of the Malware Marauders, restoring peace to Cybersphere."),
                Tuple.Create(11, "Celebrated as a digital hero, Alex stands at the forefront of innovation, using the knowledge gained to create groundbreaking applications that shape the future of technology."),
                Tuple.Create(9, "In a climactic battle, Alex and the Syntax Sentinels engage in a virtual war, using complex algorithms and strategic thinking to outwit the Malware Marauders' schemes."),
                Tuple.Create(5, "Inside the fortress, a virtual reality riddle awaits – a puzzle that can only be solved by applying principles of encryption and decryption learned during countless late-night study sessions."),
                Tuple.Create(6, "Emerging victorious, Alex discovers the hidden Repository of the Ancients, a collection of long-lost IT texts rumoured to contain the ultimate programming language."),
                Tuple.Create(8, "The guild faces its nemesis in the form of the Malware Marauders, a rival group aiming to spread chaos and disrupt the digital realm.")
            };

            foreach (var story in storyData)
            {
                list.AddNode(story.Item1, story.Item2);
            }
        }
    }
}