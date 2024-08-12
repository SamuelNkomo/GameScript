using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace GameScript
{
    public partial class MainWindow : Window
    {
        private LinkedList gameScript;
        private Node currentNode;
        private Stack<Node> previousNodes;  // Stack to keep track of previous nodes

        public MainWindow()
        {
            InitializeComponent();
            InitializeScript();
            DisplayFullScript();
            DisplayCurrentLine();
        }

        private void InitializeScript()
        {
            gameScript = new LinkedList();
            ScriptManager manager = new ScriptManager();
            LinkedListSort sorter = new LinkedListSort();

            // Populate and sort the linked list with the provided game script
            manager.PopulateLinkedList(gameScript);
            gameScript.Head = sorter.MergeSort(gameScript.Head);

            // Initialize the stack and set the starting point for line-by-line navigation
            previousNodes = new Stack<Node>();
            currentNode = gameScript.Head;
        }

        private void DisplayFullScript()
        {
            Node node = gameScript.Head;
            FullScriptTextBox.Clear();
            while (node != null)
            {
                FullScriptTextBox.AppendText($"{node.StoryNumber}: {node.StoryText}\n");
                node = node.Next;
            }
        }

        private void DisplayCurrentLine()
        {
            if (currentNode != null)
            {
                CurrentLineTextBox.Text = currentNode.StoryText;
            }
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            if (currentNode != null && currentNode.Next != null)
            {
                // Push the current node onto the stack before moving to the next one
                previousNodes.Push(currentNode);
                currentNode = currentNode.Next;
                DisplayCurrentLine();
            }
        }

        private void PreviousButton_Click(object sender, RoutedEventArgs e)
        {
            if (previousNodes.Count > 0)
            {
                // Pop the last node from the stack and set it as the current node
                currentNode = previousNodes.Pop();
                DisplayCurrentLine();
            }
            else
            {
                MessageBox.Show("No previous lines to display.");
            }
        }
    }
}