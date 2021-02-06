using System;

namespace ManipulatingVectors
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Write("--------------------------------------------  ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("MANIPULATING VECTORS");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("  --------------------------------------------------\n");
            Console.WriteLine(" $show                   Shows the vector values");
            Console.WriteLine(" $add V [V ...]          Add the values at the end of the structure");
            Console.WriteLine(" end                     Exits the program");
            Console.WriteLine(" rshow                   Shows the structure values from the last to the first");
            Console.WriteLine(" $find V [V ...]         Returns the index of the first occurrence of the sought values or -1 if it does not exist");
            Console.WriteLine(" $ins ind V              Inserts this value V in the ind position of the structure");
            Console.WriteLine(" $rmi ind                Removes the element given the index. If the index does not exist, it reports the failure");
            Console.WriteLine(" $rma V                  Removes all elements that contain that value.");
            Console.WriteLine(" $rma V                  Removes all elements that contain that value\n");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
        }
    }
}