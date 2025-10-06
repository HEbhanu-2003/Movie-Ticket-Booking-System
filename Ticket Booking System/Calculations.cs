using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Xml.Schema;

namespace Ticket_Booking_System
{
    internal class Calculations
    {

        public int price;
        public int income;
        public int total;

        public Calculations()
        {
            price = 0;
            income = 0;
            total = 0;
        }
    }

    class CalPrice : Calculations
    {

        public double Multiply(int tickets)
        {

            price = tickets;
            price = tickets * 500;
            return price;
        }
    }


}
