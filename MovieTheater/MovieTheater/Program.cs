using System;
using System.Collections.Generic;

namespace MovieTheater
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = "";
            Room myRoom = new Room();
     
            Console.Clear();
            Menu.Show();
            do
            {
                String[] lineCommand = Console.ReadLine().Split(' ');
                command = lineCommand[0];
                string[] parameters = new string[lineCommand.Length - 1];

                for (int index = 0; index < parameters.Length; index++)
                {
                    parameters[index] = lineCommand[index + 1];
                }

                switch (command)
                {
                    case "show": myRoom.Show(); break;
                    case "start": myRoom.Start(parameters[0]); break;
                    case "reserve": myRoom.Reserve(parameters); break;
                    case "cancel": myRoom.Cancel(parameters[0]); break;
                    default: break;
                }
            } while (command != "exit");
        }

    }
    
}
