using System;
using System.Collections.Generic;
using System.Text;
using ShipperApplicationLibrary.Users;

namespace ShipperApplicationLibrary.Users
{
    public class Driver : User
    {
        private string dpwd;
        public string dusrname;
        public string idproof;
        public string vehicletype;
        private string Dpwd { get; set; }
        public string Dusrname { get; set; }

        public void Accept_order()
        {
            Console.Write("\nEnter source location\n");
            source = Console.ReadLine();
            if (source == "hyderabad" || source == "banglore")
            {
                Console.WriteLine("Order accpeted successfully");
            }
            else
            {
                Console.WriteLine("Not able to accept the order");
            }

        }

    }
}
