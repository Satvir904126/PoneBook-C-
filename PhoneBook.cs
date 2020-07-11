using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_Book_App
{
    class PhoneBook
    {
        public static new List<PhoneBookListing> phoneBookListings = new List<PhoneBookListing>()
        {
            new PhoneBookListing("Samar","Girn","123456789"),
            new PhoneBookListing("Sam","Saini","123342342"),
            new PhoneBookListing("Raj","Vir","9083244224"),
            new PhoneBookListing("Karan","Vir","777756789"),
            new PhoneBookListing("Sunny","Pal","1457856789"),
            new PhoneBookListing("Kiran","Preet","1200000089"),
            new PhoneBookListing("Ravi","Singh","123450089"),
            new PhoneBookListing("Arif","Ali","0000226789")
  };
        public static List<PhoneBookListing> SearchLastName(string lastName)
        {
            List<PhoneBookListing> toReturn = new List<PhoneBookListing>();
            foreach (PhoneBookListing entry in phoneBookListings)
                if (entry.LastName == lastName)
                    toReturn.Add(entry);
            return toReturn;
        }




    }
}
