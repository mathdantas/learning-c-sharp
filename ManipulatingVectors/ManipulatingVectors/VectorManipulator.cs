using System;
using System.Collections.Generic;

namespace ManipulatingVectors
{
    public static class VectorManipulator
    {
        public static void Show(List<int> myVector)
        {
            Console.Write("[ ");
            foreach (var element in myVector)
            {
                Console.Write(element + " ");
            }
            Console.Write("]\n");
        }
        public static void Rshow(List<int> myVector)
        {
            myVector.Reverse();
            Console.Write("[ ");
            foreach (var element in myVector)
            {
                Console.Write(element + " ");
            }
            Console.Write("]\n");
            myVector.Reverse();
        }


        public static void Add(List<int> myVector, int[] parameters)
        {
            for(int index = 0; index < parameters.Length; index++)
            {
                myVector.Add(parameters[index]);
            }
        }

        public static void Find(List<int> myVector, int[] parameters)
        {
            List<int> indexVector = new List<int>();
            foreach(var element in parameters)
            {
                indexVector.Add(myVector.FindIndex(x => x == element));
            }
            Show(indexVector);
        }

        public static void Ins(List<int> myVector, int[] parameters)
        {
            myVector.Insert(parameters[0], parameters[1]);
        }

        public static void Rmi(List<int> myVector, int[] parameters)
        {
            try
            {
                myVector.RemoveAt(parameters[0]);
            }
            catch
            {
                Console.WriteLine("Fail");
            }
            
        }
        public static void Rma(List<int> myVector, int[] parameter)
        {
            myVector.RemoveAll(x => x == parameter[0]);
        }
    }
}