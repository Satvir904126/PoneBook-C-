using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_Book_App
{
    class PhoneBookListing
    {
        public string LastName { get; private set; }
        public string FirstName { get; private set; }
        public string PhoneNumber { get; private set; }

        public PhoneBookListing(string firstName, string lastName, string phoneNumber)
        {
            LastName = lastName;
            FirstName = firstName;
            PhoneNumber = phoneNumber;
        }
        //static float GetUserint()
        //{
        //    bool successfulParse = false;
        //    int toReturn = 0;
        //    do
        //    {
        //        successfulParse = int.TryParse(Console.ReadLine(), out toReturn);
        //    } while (!successfulParse);
        //    return toReturn;
        }
    }

