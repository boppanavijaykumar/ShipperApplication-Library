using System;
using System.Collections.Generic;
using System.Text;
using ShipperApplicationLibrary.Shipments;
using ShipperApplicationLibrary.Users;

namespace ShipperApplicationLibrary.Payments
{
    class Payments : Shipper
    {
        public Driver dusrname;
        private string paymentmode;
        private string cost;
        private string cardno;
        private string expiry;
        private string cvv;

        public void Pay()
        {
            if (pay_id == "credit")
            {
                Console.WriteLine("enter the card no");
                cardno = Console.ReadLine();
                Console.WriteLine("enter the expiry date");
                expiry = Console.ReadLine();
                Console.WriteLine("enter the cvv");
                cvv = Console.ReadLine();
                if (cardno != null && expiry != null && cvv != null)
                {
                    Console.WriteLine("payment successfull");
                }
                else
                {
                    Console.WriteLine("Not successfull try again");
                }
            }
            if (pay_id == "debit")
            {
                Console.WriteLine("enter the card no");
                cardno = Console.ReadLine();
                Console.WriteLine("enter the expiry date");
                expiry = Console.ReadLine();
                Console.WriteLine("enter the cvv");
                cvv = Console.ReadLine();
                if (cardno != null && expiry != null && cvv != null)
                {
                    Console.WriteLine("payment successfull");
                }
                else
                {
                    Console.WriteLine("Not successfull try again");
                }
            }
        }
    }

}
