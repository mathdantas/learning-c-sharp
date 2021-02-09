using System;

namespace MovieTheater
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Write("-----------------------------------  ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Movie theater");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("  -----------------------------------------\n");
            Console.WriteLine(" $show                 Use the show command to display the allocation of seats in the room");
            Console.WriteLine(" $start N              The start command starts a room with N seats");
            Console.WriteLine(" $reserve A B C        The command book reserve seat A for person B with telephone C");
            Console.WriteLine(" $cancel               A The cancel command cancels person A's reservation");

            Console.WriteLine("---------------------------------------------------------------------------------------------");
        }
    }
}