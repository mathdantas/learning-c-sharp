using System;   
using System.Collections.Generic;

namespace MovieTheater
{
    public class Room
    {
        private int SeatsInUse = 0;
        public int NumberOfSeats { get; set; }
        public List<Client> Seats { get; set; }

        public Room()
        {
            NumberOfSeats = 0;
            Seats = new List<Client>();
        }

        public void Show()
        {
            Console.Write("[ ");
            foreach (Client item in Seats)
            {
                if(item.Id == "-")
                {
                    Console.Write($"{item.Id} ");
                }
                else
                {
                    Console.Write($"{item.Id}:{item.PhoneNumber} ");
                }
                
            }
            Console.Write("]\n");
        }

        public void Start(string numberOfSeats)
        {
            Seats.Clear();
            NumberOfSeats = Int32.Parse(numberOfSeats);
        
            for (int i = 0; i < NumberOfSeats; i++)
            {
                Seats.Add(new Client("-", ""));
            }
        }

        public void Reserve(string[] parameters)
        {
            try
            {
                if (Seats[Int32.Parse(parameters[2])].Id == "-")
                {
                    if (!(Seats.Exists(x => x.Id == parameters[0])))
                    {
                        Seats[Int32.Parse(parameters[2])] = new Client(parameters[0], parameters[1]);
                    }
                    else
                    {
                        Console.WriteLine("failure: client is already at the cinema");
                    }
                    
                }else
                {
                    if (Seats[Int32.Parse(parameters[2])].Id == parameters[0])
                    {
                        Console.WriteLine("failure: client is already at the cinema");
                    }
                    else
                    {
                        Console.WriteLine("failure: seat already reserved");

                    }
                }

            }
            catch (Exception)
            {
                Console.WriteLine("failure: this seat does not exist");
                throw;
            }
        }

        public void Cancel(string id)
        {
            foreach (var item in Seats)
            {
                if(item.Id == id)
                {
                    item.Id = "-";
                    item.PhoneNumber = "";
                }
            }
        }
    }
}