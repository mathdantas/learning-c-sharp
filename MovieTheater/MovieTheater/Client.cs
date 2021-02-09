using System;

namespace MovieTheater
{
    public class Client
    {
        public string Id { get; set; }
        public string PhoneNumber { get; set; }

        public Client(string id, string phoneNumber)
        {
            Id = id;
            PhoneNumber = phoneNumber;
        }
    }
}