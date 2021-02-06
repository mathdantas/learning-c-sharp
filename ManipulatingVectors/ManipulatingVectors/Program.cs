using System;
using System.Collections.Generic;

namespace ManipulatingVectors
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();
            Menu.Show();
            string command = "";
            List<int> myVector = new List<int>();
            do
            {
                String[] words = Console.ReadLine().Split(' ');
                command = words[0];
                int[] parameters = new int[words.Length - 1];

                for (int index = 0; index < parameters.Length; index++)
                {
                    parameters[index] = Int32.Parse(words[index + 1]);
                }

                switch (command)
                {
                    case "show": VectorManipulator.Show(myVector); break;
                    case "add": VectorManipulator.Add(myVector, parameters); break;
                    case "end": System.Environment.Exit(0); break;
                    case "rshow": VectorManipulator.Rshow(myVector); break;
                    case "find": VectorManipulator.Find(myVector, parameters); break;
                    case "ins": VectorManipulator.Ins(myVector, parameters); break;
                    case "rmi": VectorManipulator.Rmi(myVector, parameters); break;
                    case "rma": VectorManipulator.Rma(myVector, parameters); break;
                    default: Menu.Show(); break;

                }
            } while (command != "end");

        }
    }
}
