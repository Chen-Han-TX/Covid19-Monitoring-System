﻿//============================================================
// Student Number : S10202961, S10204388
// Student Name : Chen Han, Chung Tze Siong
// Module Group : T04
//============================================================

using System;
using System.Collections.Generic;
using System.Text;

//Done
namespace COVID_19_Monitoring_System
{
    class SafeEntry
    {
        private DateTime checkIn;   

        public DateTime CheckIn
        {
            get { return checkIn; }
            set { checkIn = value; }
        }

        private DateTime checkOut;

        public DateTime CheckOut
        {
            get { return checkOut; }
            set { checkOut = value; }
        }

        private BusinessLocation location;

        public BusinessLocation Location
        {
            get { return location; }
            set { location = value; }
        }


        public SafeEntry()
        {

        }


        public SafeEntry(DateTime ci, DateTime co, BusinessLocation bl)
        {
            CheckIn = ci;
            CheckOut = co;
            Location = bl;
        }

        public void PerformCheckOut()
        {
            Location.VisitorsNow -= 1;
            CheckOut = DateTime.Now;
            Console.WriteLine("User has been checked out.");
        }

        public override string ToString()
        {
            return "Check-in: " + CheckIn + "\nCheck-out: " + CheckOut;
        }


    }
}
