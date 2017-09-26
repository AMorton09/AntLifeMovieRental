using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntLifeF2Team9
{
    class User
    {
        public int userID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string zip { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string email { get; set; }
        public string passwordHash { get; set; }
        public string passwordSalt { get; set; }
        public string membershipLevel { get; set; }
        public bool employee { get; set; }
        public string expDate { get; set; }
        public double amountSpent { get; set; }


        public override string ToString()
        {
            return String.Format("UserID = {0}, First Name = {1}, Last Name = {2}, Address = {3}, City = {4}, Zip = {5}, State = {6}, Country = {7}, E-Mail = {8}, Membership Level = {9}, Employee = {10}, Membership Expiration Date = {11}, Amount Spent = {12}",userID, firstName, lastName, address, city, zip, state, country,email, membershipLevel, employee, expDate, amountSpent);
        }


    }
}
